using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Kondominium.API.Controllers
{
    public class BaseController : Controller
    {
        public static string NomeSistema = "Kondominium";
        public static string Versao = string.Empty;

        public new IActionResult Response(object result, List<string> notifications)
        {
            if (!notifications.Any())
            {
                try
                {                    
                    return Ok(new
                    {
                        success = true,
                        data = result
                    });
                }
                catch
                {
                    return BadRequest(new
                    {
                        success = false,
                        errors = new[] { "Ocorreu uma falha interna no servidor." }
                    });
                }
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    errors = notifications
                });
            }
        }
    }
}
