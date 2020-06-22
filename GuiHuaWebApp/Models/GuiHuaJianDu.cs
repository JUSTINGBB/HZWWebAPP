using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GuiHuaWebApp.Models
{
    /// <summary>
    /// 规划监督表
    /// </summary>
    [Table ("GuiHuaJianDu")]
    public class GuiHuaJianDu
    {
        public string ImageList = "ImageList";
        /// <summary>
        /// 项目Id
        /// </summary>
        [DisplayName("项目编号")]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="项目名称是必填项")]
        [DisplayName("项目名称")]
        public String  PrjName { get; set; }
        
        [DisplayName("建设单位")]
        public String JSDanWei { get; set; }
        
        [DisplayName("建设位置")]
        public String JSWeiZhi { get; set; }
        
        [DisplayName("工规证号")]
        public String GongGuiNum { get; set; }
        
        [DisplayName("建设规模")]
        public double JSGuiMo { get; set; }
        
        [DisplayName("是否验线")]
        public bool SFYanXian { get; set; }


        /// <summary>
        /// 是否施工现场检查
        /// </summary>
        [DisplayName("第一次")]
        public bool IsChecked1 { get; set; }
 
        [DisplayName("第二次")]
        public bool IsChecked2 { get; set; }
        
        [DisplayName("施工现场是否按要求设置规划公布牌")]
        public bool checkItem1 { get; set; }
        
        [DisplayName("工程主体是否按规划许可内容进行建设")]
        public bool checkItem2 { get; set; }
        
        [DisplayName("建筑工程配套管线开工建设前是否备案")]
        public bool checkItem3 { get; set; }
        
        [DisplayName("是否签订工程管线的竣工测绘合同")]
        public bool checkItem4 { get; set; }
        
        [DisplayName("地下管线是否在覆土前进行跟踪测绘，其中采用深埋非开挖的，是否在管线封口前进行竣工测绘")]
        public bool checkItem5 { get; set; }
        
        [DisplayName("现场是否存在明显且重大的违法建设情形")]
        public bool checkItem6 { get; set; }
        
        [DisplayName("是否提醒建设单位及时办理复验、竣工规划核实等其他注意事项")]
        public bool checkItem7 { get; set; }
        
        [DisplayName("现场照片")]
        public String Photos { get; set; }
        
        [DisplayName("是否发温馨提示卡")]
        public bool SFFaWenXinTiShiKa { get; set; }
        
        [DisplayName("是否竣工核实")]
        public bool SFJunGongHeShi { get; set; }
        
        [DisplayName("备注")]
        public String BeiZhu { get; set; }

    }
}