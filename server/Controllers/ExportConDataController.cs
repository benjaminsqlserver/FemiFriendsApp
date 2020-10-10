using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FemiFriendsApp.Data;

namespace FemiFriendsApp
{
    public partial class ExportConDataController : ExportController
    {
        private readonly ConDataContext context;

        public ExportConDataController(ConDataContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/ConData/countries/csv")]
        [HttpGet("/export/ConData/countries/csv(fileName='{fileName}')")]
        public FileStreamResult ExportCountriesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Countries, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/countries/excel")]
        [HttpGet("/export/ConData/countries/excel(fileName='{fileName}')")]
        public FileStreamResult ExportCountriesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Countries, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/genders/csv")]
        [HttpGet("/export/ConData/genders/csv(fileName='{fileName}')")]
        public FileStreamResult ExportGendersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Genders, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/genders/excel")]
        [HttpGet("/export/ConData/genders/excel(fileName='{fileName}')")]
        public FileStreamResult ExportGendersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Genders, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/myfriends/csv")]
        [HttpGet("/export/ConData/myfriends/csv(fileName='{fileName}')")]
        public FileStreamResult ExportMyFriendsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.MyFriends, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/myfriends/excel")]
        [HttpGet("/export/ConData/myfriends/excel(fileName='{fileName}')")]
        public FileStreamResult ExportMyFriendsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.MyFriends, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/states/csv")]
        [HttpGet("/export/ConData/states/csv(fileName='{fileName}')")]
        public FileStreamResult ExportStatesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.States, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/states/excel")]
        [HttpGet("/export/ConData/states/excel(fileName='{fileName}')")]
        public FileStreamResult ExportStatesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.States, Request.Query), fileName);
        }
    }
}
