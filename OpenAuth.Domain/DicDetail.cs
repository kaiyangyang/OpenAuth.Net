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
	/// 数据字典详情
	/// </summary>
    public partial class DicDetail
    {
        public DicDetail()
        {
          this.Id= 0;
          this.Value= string.Empty;
          this.Text= string.Empty;
          this.DicId= 0;
          this.SortNo= 0;
          this.Status= 0;
          this.Description= string.Empty;
        }

        /// <summary>
	    /// ID
	    /// </summary>
        public int Id { get; set; }
        /// <summary>
	    /// 值
	    /// </summary>
        public string Value { get; set; }
        /// <summary>
	    /// 文本描述
	    /// </summary>
        public string Text { get; set; }
        /// <summary>
	    /// 所属字典ID
	    /// </summary>
        public int DicId { get; set; }
        /// <summary>
	    /// 排序号
	    /// </summary>
        public int SortNo { get; set; }
        /// <summary>
	    /// 状态
	    /// </summary>
        public int Status { get; set; }
        /// <summary>
	    /// 描述
	    /// </summary>
        public string Description { get; set; }

    }
}