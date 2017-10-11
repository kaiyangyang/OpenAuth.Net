﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAuth.Domain
{
    /// <summary>
	/// 组织表
	/// </summary>
    public partial class Org : Entity
    {
        public Org()
        {
          this.CascadeId= string.Empty;
          this.Name= string.Empty;
          this.HotKey= string.Empty;
          this.ParentName= string.Empty;
          this.IconName= string.Empty;
          this.Status= 0;
          this.Type= 0;
          this.BizCode= string.Empty;
          this.CustomCode= string.Empty;
          this.CreateTime= DateTime.Now;
          this.CreateId= 0;
          this.SortNo= 0;
          this.ParentId= string.Empty;
        }

        /// <summary>
	    /// 节点语义ID
	    /// </summary>
        public string CascadeId { get; set; }
        /// <summary>
	    /// 组织名称
	    /// </summary>
        public string Name { get; set; }
        /// <summary>
	    /// 热键
	    /// </summary>
        public string HotKey { get; set; }
        /// <summary>
	    /// 父节点名称
	    /// </summary>
        public string ParentName { get; set; }
        /// <summary>
	    /// 是否叶子节点
	    /// </summary>
        public bool IsLeaf { get; set; }
        /// <summary>
	    /// 是否自动展开
	    /// </summary>
        public bool IsAutoExpand { get; set; }
        /// <summary>
	    /// 节点图标文件名称
	    /// </summary>
        public string IconName { get; set; }
        /// <summary>
	    /// 当前状态
	    /// </summary>
        public int Status { get; set; }
        /// <summary>
	    /// 组织类型
	    /// </summary>
        public int Type { get; set; }
        /// <summary>
	    /// 业务对照码
	    /// </summary>
        public string BizCode { get; set; }
        /// <summary>
	    /// 自定义扩展码
	    /// </summary>
        public string CustomCode { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime CreateTime { get; set; }
        /// <summary>
	    /// 创建人ID
	    /// </summary>
        public int CreateId { get; set; }
        /// <summary>
	    /// 排序号
	    /// </summary>
        public int SortNo { get; set; }
        /// <summary>
	    /// 父节点流水号
	    /// </summary>
        public string ParentId { get; set; }

    }
}