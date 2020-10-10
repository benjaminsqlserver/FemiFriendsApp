using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using FemiFriendsApp.Models.ConData;
using Microsoft.EntityFrameworkCore;

namespace FemiFriendsApp.Pages
{
    public partial class CountriesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected ConDataService ConData { get; set; }
        protected RadzenGrid<FemiFriendsApp.Models.ConData.Country> grid0;

        IEnumerable<FemiFriendsApp.Models.ConData.Country> _getCountriesResult;
        protected IEnumerable<FemiFriendsApp.Models.ConData.Country> getCountriesResult
        {
            get
            {
                return _getCountriesResult;
            }
            set
            {
                if (!object.Equals(_getCountriesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCountriesResult", NewValue = value, OldValue = _getCountriesResult };
                    _getCountriesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var conDataGetCountriesResult = await ConData.GetCountries();
            getCountriesResult = conDataGetCountriesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddCountry>("Add Country", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(FemiFriendsApp.Models.ConData.Country args)
        {
            var dialogResult = await DialogService.OpenAsync<EditCountry>("Edit Country", new Dictionary<string, object>() { {"CountryID", args.CountryID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var conDataDeleteCountryResult = await ConData.DeleteCountry(data.CountryID);
                    if (conDataDeleteCountryResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception conDataDeleteCountryException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Country");
            }
        }
    }
}
