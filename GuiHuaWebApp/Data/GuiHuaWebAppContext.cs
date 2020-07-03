using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuiHuaWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GuiHuaWebApp.Data
{
    public class GuiHuaWebAppContext : IdentityDbContext
    {
        public GuiHuaWebAppContext (DbContextOptions<GuiHuaWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<GuiHuaWebApp.Models.GuiHuaJianDu> GuiHuaJianDu { get; set; }
    }
}
