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
    public partial class AddCountryComponent : ComponentBase
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

        FemiFriendsApp.Models.ConData.Country _country;
        protected FemiFriendsApp.Models.ConData.Country country
        {
            get
            {
                return _country;
            }
            set
            {
                if (!object.Equals(_country, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "country", NewValue = value, OldValue = _country };
                    _country = value;
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
            country = new FemiFriendsApp.Models.ConData.Country(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(FemiFriendsApp.Models.ConData.Country args)
        {
            try
            {
                var conDataCreateCountryResult = await ConData.CreateCountry(country);
                DialogService.Close(country);
            }
            catch (System.Exception conDataCreateCountryException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new Country!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
