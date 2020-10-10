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
    public partial class AddStateComponent : ComponentBase
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

        FemiFriendsApp.Models.ConData.State _state;
        protected FemiFriendsApp.Models.ConData.State state
        {
            get
            {
                return _state;
            }
            set
            {
                if (!object.Equals(_state, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "state", NewValue = value, OldValue = _state };
                    _state = value;
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
            state = new FemiFriendsApp.Models.ConData.State(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(FemiFriendsApp.Models.ConData.State args)
        {
            try
            {
                var conDataCreateStateResult = await ConData.CreateState(state);
                DialogService.Close(state);
            }
            catch (System.Exception conDataCreateStateException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new State!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
