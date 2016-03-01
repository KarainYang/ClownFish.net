﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClownFish.Log.Configuration
{
#if _MongoDB_

	/// <summary>
	/// MongDbWriter的配置信息
	/// </summary>
	public sealed class MongDbWriterConfig : BaseWriterConfig
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public MongDbWriterConfig()
		{
			this.Name = "MongDb";
		}

		/// <summary>
		/// MongDB的连接字符串
		/// </summary>
		[XmlAttribute]
		public string ConnectionString { get; set; }


		/// <summary>
		/// 验证属性是否配置正确
		/// </summary>
		public override void Valid()
		{
			if( string.IsNullOrEmpty(ConnectionString) )
				throw new LogConfigException("日志配置文件中，没有为MongDbWriter指定ConnectionString属性。");

		}

	}


#else
	/// <summary>
	/// MongDbWriter的配置信息（空实现）
	/// </summary>
	public sealed class MongDbWriterConfig : BaseWriterConfig
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public MongDbWriterConfig()
		{
			this.Name = "MongDb";			
		}
	}
#endif
}
