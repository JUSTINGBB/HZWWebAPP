using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuiHuaWebApp.Data;
using GuiHuaWebApp.Models;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;

namespace GuiHuaWebApp.Controllers
{
    public class GuiHuaJianDusController : Controller
    {
        private readonly GuiHuaWebAppContext _context;

        public GuiHuaJianDusController(GuiHuaWebAppContext context)
        {
            _context = context;
        }

        // GET: GuiHuaJianDus
        public async Task<IActionResult> Index(string filter ,int pageSize = 5,int pageIndex = 1,
            string sortExpression = "PrjName")
        {
            var qry = _context.GuiHuaJianDu.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                qry = qry.Where(p => p.PrjName.Contains(filter));

            }
            int count = qry.Count();
            ViewData["count"] = count;
            var model = await PagingList.CreateAsync(qry, pageSize, pageIndex, sortExpression, "Id");
            model.RouteValue = new RouteValueDictionary
            {
                {"filter",filter }
            };

            //return View(await _context.GuiHuaJianDu.ToListAsync());
            return View(model);
        }

        // GET: GuiHuaJianDus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guiHuaJianDu = await _context.GuiHuaJianDu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guiHuaJianDu == null)
            {
                return NotFound();
            }

            return View(guiHuaJianDu);
        }

        // GET: GuiHuaJianDus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GuiHuaJianDus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PrjName,JSDanWei,JSWeiZhi,GongGuiNum,JSGuiMo,SFYanXian,IsChecked1,IsChecked2,checkItem1,checkItem2,checkItem3,checkItem4,checkItem5,checkItem6,checkItem7,Photos,SFFaWenXinTiShiKa,SFJunGongHeShi,BeiZhu")] GuiHuaJianDu guiHuaJianDu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guiHuaJianDu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guiHuaJianDu);
        }

        // GET: GuiHuaJianDus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guiHuaJianDu = await _context.GuiHuaJianDu.FindAsync(id);
            if (guiHuaJianDu == null)
            {
                return NotFound();
            }
            return View(guiHuaJianDu);
        }

        // POST: GuiHuaJianDus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PrjName,JSDanWei,JSWeiZhi,GongGuiNum,JSGuiMo,SFYanXian,IsChecked1,IsChecked2,checkItem1,checkItem2,checkItem3,checkItem4,checkItem5,checkItem6,checkItem7,Photos,SFFaWenXinTiShiKa,SFJunGongHeShi,BeiZhu")] GuiHuaJianDu guiHuaJianDu)
        {
            if (id != guiHuaJianDu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guiHuaJianDu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuiHuaJianDuExists(guiHuaJianDu.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(guiHuaJianDu);
        }

        // GET: GuiHuaJianDus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guiHuaJianDu = await _context.GuiHuaJianDu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guiHuaJianDu == null)
            {
                return NotFound();
            }

            return View(guiHuaJianDu);
        }

        // POST: GuiHuaJianDus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guiHuaJianDu = await _context.GuiHuaJianDu.FindAsync(id);
            _context.GuiHuaJianDu.Remove(guiHuaJianDu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuiHuaJianDuExists(int id)
        {
            return _context.GuiHuaJianDu.Any(e => e.Id == id);
        }

        public IActionResult map()
        {
            return View();
        }

        public IActionResult TongJiFenXi()
        {
            return View();
        }
    }
}
