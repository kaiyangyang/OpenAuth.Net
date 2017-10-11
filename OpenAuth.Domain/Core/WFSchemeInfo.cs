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
	/// 工作流模板信息表
	/// </summary>
    public partial class WFSchemeInfo : Entity
    {
        public WFSchemeInfo()
        {
          this.SchemeCode= string.Empty;
          this.SchemeName= string.Empty;
          this.SchemeType= string.Empty;
          this.SchemeVersion= string.Empty;
          this.SchemeCanUser= string.Empty;
          this.Description= string.Empty;
          this.CreateDate= DateTime.Now;
          this.CreateUserId= string.Empty;
          this.CreateUserName= string.Empty;
          this.ModifyDate= DateTime.Now;
          this.ModifyUserId= string.Empty;
          this.ModifyUserName= string.Empty;
        }

        /// <summary>
	    /// 流程编号
	    /// </summary>
        public string SchemeCode { get; set; }
        /// <summary>
	    /// 流程名称
	    /// </summary>
        public string SchemeName { get; set; }
        /// <summary>
	    /// 流程分类
	    /// </summary>
        public string SchemeType { get; set; }
        /// <summary>
	    /// 流程内容版本
	    /// </summary>
        public string SchemeVersion { get; set; }
        /// <summary>
	    /// 流程模板使用者
	    /// </summary>
        public string SchemeCanUser { get; set; }
        /// <summary>
	    /// 表单类型
	    /// </summary>
        public int? FrmType { get; set; }
        /// <summary>
	    /// 模板权限类型0所有人,1指定成员
	    /// </summary>
        public int? AuthorizeType { get; set; }
        /// <summary>
	    /// 排序码
	    /// </summary>
        public int? SortCode { get; set; }
        /// <summary>
	    /// 删除标记
	    /// </summary>
        public int? DeleteMark { get; set; }
        /// <summary>
	    /// 有效
	    /// </summary>
        public int? EnabledMark { get; set; }
        /// <summary>
	    /// 备注
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 创建时间
	    /// </summary>
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
	    /// 创建用户主键
	    /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
	    /// 创建用户
	    /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
	    /// 修改时间
	    /// </summary>
        public System.DateTime? ModifyDate { get; set; }
        /// <summary>
	    /// 修改用户主键
	    /// </summary>
        public string ModifyUserId { get; set; }
        /// <summary>
	    /// 修改用户
	    /// </summary>
        public string ModifyUserName { get; set; }

    }
}