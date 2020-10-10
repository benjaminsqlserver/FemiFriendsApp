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
    public partial class MyFriendsComponent : ComponentBase
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
        protected RadzenGrid<FemiFriendsApp.Models.ConData.MyFriend> grid0;

        IEnumerable<FemiFriendsApp.Models.ConData.MyFriend> _getMyFriendsResult;
        protected IEnumerable<FemiFriendsApp.Models.ConData.MyFriend> getMyFriendsResult
        {
            get
            {
                return _getMyFriendsResult;
            }
            set
            {
                if (!object.Equals(_getMyFriendsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getMyFriendsResult", NewValue = value, OldValue = _getMyFriendsResult };
                    _getMyFriendsResult = value;
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
            var conDataGetMyFriendsResult = await ConData.GetMyFriends();
            getMyFriendsResult = conDataGetMyFriendsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddMyFriend>("Add My Friend", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(FemiFriendsApp.Models.ConData.MyFriend args)
        {
            var dialogResult = await DialogService.OpenAsync<EditMyFriend>("Edit My Friend", new Dictionary<string, object>() { {"FriendID", args.FriendID} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var conDataDeleteMyFriendResult = await ConData.DeleteMyFriend(data.FriendID);
                    if (conDataDeleteMyFriendResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception conDataDeleteMyFriendException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete MyFriend");
            }
        }
    }
}
