using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace E_CommerceManageMentSystem.Data.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Customer = "Customer";
        public static string Guest = "Guest";

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            if (isAdmin)
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Admin,Text=Admin}
                };
            }
            else
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Customer,Text=Customer},
                    new SelectListItem{Value=Guest,Text=Guest}
                };
            }
        }
    }
}
