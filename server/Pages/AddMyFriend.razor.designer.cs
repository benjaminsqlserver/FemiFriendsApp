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
    public partial class AddMyFriendComponent : ComponentBase
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

        IEnumerable<FemiFriendsApp.Models.ConData.Gender> _getGendersResult;
        protected IEnumerable<FemiFriendsApp.Models.ConData.Gender> getGendersResult
        {
            get
            {
                return _getGendersResult;
            }
            set
            {
                if (!object.Equals(_getGendersResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getGendersResult", NewValue = value, OldValue = _getGendersResult };
                    _getGendersResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

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

        IEnumerable<FemiFriendsApp.Models.ConData.State> _getStatesResult;
        protected IEnumerable<FemiFriendsApp.Models.ConData.State> getStatesResult
        {
            get
            {
                return _getStatesResult;
            }
            set
            {
                if (!object.Equals(_getStatesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getStatesResult", NewValue = value, OldValue = _getStatesResult };
                    _getStatesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        FemiFriendsApp.Models.ConData.MyFriend _myfriend;
        protected FemiFriendsApp.Models.ConData.MyFriend myfriend
        {
            get
            {
                return _myfriend;
            }
            set
            {
                if (!object.Equals(_myfriend, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "myfriend", NewValue = value, OldValue = _myfriend };
                    _myfriend = value;
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
            var conDataGetGendersResult = await ConData.GetGenders();
            getGendersResult = conDataGetGendersResult;

            var conDataGetCountriesResult = await ConData.GetCountries();
            getCountriesResult = conDataGetCountriesResult;

            var conDataGetStatesResult = await ConData.GetStates();
            getStatesResult = conDataGetStatesResult;

            myfriend = new FemiFriendsApp.Models.ConData.MyFriend(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(FemiFriendsApp.Models.ConData.MyFriend args)
        {
            try
            {
                var conDataCreateMyFriendResult = await ConData.CreateMyFriend(myfriend);
                DialogService.Close(myfriend);
            }
            catch (System.Exception conDataCreateMyFriendException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new MyFriend!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
