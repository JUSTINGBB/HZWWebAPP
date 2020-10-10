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
using Microsoft.AspNetCore.Http;
using System.Collections;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;

namespace GuiHuaWebApp.Controllers
{
    public class GuiHuaJianDusController : Controller
    {
        private readonly GuiHuaWebAppContext _context;
        //private static readonly int _PAGESIZE = 5;
        //private static readonly int _PAGEINDEX = 1;
        private static int _pageIndex;
        private static int _pageSize;
        public GuiHuaJianDusController(GuiHuaWebAppContext context)
        {
            _context = context;
        }

        // GET: GuiHuaJianDus
        public async Task<IActionResult> Index(string filter ,int pageSize = 5,int pageIndex = 1,
            string sortExpression = "Id")
        {
            ViewData["pageIndex"] = pageIndex;
            ViewData["pageSize"] = pageSize;
            _pageIndex = pageIndex;
            _pageSize = pageSize;

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
                {"filter",filter },
                {"pageSize",pageSize }
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
            ViewData["pageIndex"] = _pageIndex;
            ViewData["pageSize"] = _pageSize;
            var guiHuaJianDu = await _context.GuiHuaJianDu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guiHuaJianDu == null)
            {
                return NotFound();
            }

            return View(guiHuaJianDu);
        }

        // GET: GuiHuaJianDus/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: GuiHuaJianDus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PrjName,JSDanWei,JSWeiZhi,FaZhengTime,GongGuiNum,JSGuiMo,SFYanXian,IsChecked1,IsChecked2,checkItem1,checkItem2,checkItem3,checkItem4,checkItem5,checkItem6,checkItem7,Photos,SFFaWenXinTiShiKa,SFJunGongHeShi,BeiZhu,BiaoJi")] GuiHuaJianDu guiHuaJianDu)
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
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["pageIndex"] = _pageIndex;
            ViewData["pageSize"] = _pageSize;
            if (id == null)
            {
                return NotFound();
            }

            var guiHuaJianDu = await _context.GuiHuaJianDu.FindAsync(id);
            if (guiHuaJianDu == null)
            {
                return NotFound();
            }
            ReadPicture(id);

            return View(guiHuaJianDu);
        }

        // POST: GuiHuaJianDus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PrjName,JSDanWei,JSWeiZhi,FaZhengTime,GongGuiNum,JSGuiMo,SFYanXian,IsChecked1,IsChecked2,checkItem1,checkItem2,checkItem3,checkItem4,checkItem5,checkItem6,checkItem7,Photos,SFFaWenXinTiShiKa,SFJunGongHeShi,BeiZhu,BiaoJi")] GuiHuaJianDu guiHuaJianDu)
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
                return RedirectToAction(nameof(Index),new { pageSize=_pageSize,pageIndex=_pageIndex});
            }
            return View(guiHuaJianDu);
        }

        // GET: GuiHuaJianDus/Delete/5
        [Authorize]
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

        /// <summary>
        /// 地图
        /// </summary>
        /// <returns></returns>
        //[Authorize]
        public IActionResult map()
        {
            return View();
        }

        /// <summary>
        /// 统计分许
        /// </summary>
        /// <returns></returns>
        //[Authorize]
        public IActionResult TongJiFenXi()
        {
            return View();
        }

        /// <summary>
        /// 上传文件、图片
        /// </summary>
        /// <param name="formCollection"></param>
        /// <param name="id"></param>
        /// <param name="CrtUser"></param>
        /// <returns></returns>
        [HttpPost]
        [DisableRequestSizeLimit]
        public ActionResult UploadFiles(IFormCollection formCollection, int id, int CrtUser)
        {
            try
            {
                string dd = formCollection["File"];
                var form = formCollection;
                Hashtable hashtable = new Hashtable();
                List<string> fileNameList = null;
                //fileNameArr.Append("sdas");
                IFormFileCollection cols = Request.Form.Files;
                if(cols == null || cols.Count == 0)
                {
                    return Json(new { status = -1, message = "没有上传文件", data = hashtable });
                }
                foreach(IFormFile file in cols)
                {
                    string[] LimitPictureType = { ".JPG", ".JPGE", ".GIF", ".PNG", ".BMP" };
                    string currentPictureExtension = Path.GetExtension(file.FileName).ToUpper();
                    if (LimitPictureType.Contains(currentPictureExtension))
                    {
                        string fileFolder = Path.Combine("uploadFiles/photos", id.ToString());
                        string new_path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileFolder);
                        if (!Directory.Exists(new_path))
                        {
                            Directory.CreateDirectory(new_path);
                        }
                        string FileName = Path.GetFileNameWithoutExtension(file.FileName)+"_"
                            +DateTime.Now.ToString("yyyyMMddHHmmss_fff", DateTimeFormatInfo.InvariantInfo) 
                            + currentPictureExtension;
                        var path = Path.Combine(new_path, FileName);

                        //if (System.IO.File.Exists(path))
                        //{
                        //    return Json(new { status = 0, message = "文件已存在", data = hashtable });
                        //}
                        using (var stream = new FileStream(path, FileMode.CreateNew))
                        {
                            file.CopyTo(stream);
                            fileNameList = new List<string>();
                            fileNameList.Add(path);
                        }
                    }
                    else
                    {
                        return Json(new { status = -2, message = "请上传指定格式的图片", data = hashtable });
                    }
                }
                hashtable.Add("file", fileNameList);
                return Json(new { status = 0, message = "上传成功", data = hashtable });
            }
            catch (Exception ex)
            {

                return Json(new { status = -3, message = "上传失败", data = ex.Message });
            }
        }

        /// <summary>
        /// 读取照片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ReadPicture(int? id)
        {
            string fileFolder = Path.Combine("uploadFiles/photos", id.ToString());
            string imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileFolder);
            var imgList = new List<string>();
            if (Directory.Exists(imgPath))
            {
                var files = Directory.GetFiles(imgPath, "*.*", SearchOption.TopDirectoryOnly);
                var filesNames = files.Select(p => Path.GetFileName(p));
                var imgUrls = filesNames.Select(p =>
                {
                    return p;
                });
                var imgQuery = from name in imgUrls
                               orderby name descending
                               select name;
                if (imgQuery.ToArray().Length > 0)
                {
                    imgList = imgQuery.ToList();
                }
            }
            List<SelectListItem> ImgList = imgList.Select(p => new SelectListItem() { Text = p, Value = p }).ToList();
            ViewBag.imgList = ImgList;
            return Json(ImgList);
        }

        /// <summary>
        /// 删除照片
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imgName"></param>
        /// <returns></returns>
        public ActionResult DeletePicture(int? id,string imgName)
        {
            string fileFolder = Path.Combine("uploadFiles/photos", id.ToString());
            string imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileFolder);
            var imgFullName = Path.Combine(imgPath,imgName);
            FileInfo fileInfo = new FileInfo(imgFullName);
            string deleteInfo = "";
            try
            {
                fileInfo.Delete();
                deleteInfo = "删除成功";
            }
            catch (Exception)
            {

                throw;
            }
            return Json(new { deleteInfo = deleteInfo });
        }
    }
}
