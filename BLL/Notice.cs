using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ITCastOCSS.Model;
namespace ITCastOCSS.BLL
{
	/// <summary>
	/// Notice
	/// </summary>
	public partial class Notice
	{
		private readonly ITCastOCSS.DAL.Notice dal=new ITCastOCSS.DAL.Notice();
		public Notice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NID)
		{
			return dal.Exists(NID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ITCastOCSS.Model.Notice model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ITCastOCSS.Model.Notice model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int NID)
		{
			
			return dal.Delete(NID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string NIDlist )
		{
			return dal.DeleteList(NIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ITCastOCSS.Model.Notice GetModel(int NID)
		{
			
			return dal.GetModel(NID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ITCastOCSS.Model.Notice GetModelByCache(int NID)
		{
			
			string CacheKey = "NoticeModel-" + NID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ITCastOCSS.Model.Notice)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ITCastOCSS.Model.Notice> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ITCastOCSS.Model.Notice> DataTableToList(DataTable dt)
		{
			List<ITCastOCSS.Model.Notice> modelList = new List<ITCastOCSS.Model.Notice>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ITCastOCSS.Model.Notice model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

