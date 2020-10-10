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
    public partial class EditGenderComponent : ComponentBase
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

        [Parameter]
        public dynamic GenderID { get; set; }

        FemiFriendsApp.Models.ConData.Gender _gender;
        protected FemiFriendsApp.Models.ConData.Gender gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (!object.Equals(_gender, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "gender", NewValue = value, OldValue = _gender };
                    _gender = value;
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
            var conDataGetGenderByGenderIdResult = await ConData.GetGenderByGenderId(GenderID);
            gender = conDataGetGenderByGenderIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(FemiFriendsApp.Models.ConData.Gender args)
        {
            try
            {
                var conDataUpdateGenderResult = await ConData.UpdateGender(GenderID, gender);
                DialogService.Close(gender);
            }
            catch (System.Exception conDataUpdateGenderException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Gender");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
