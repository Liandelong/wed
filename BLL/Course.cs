using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ITCastOCSS.Model;
namespace ITCastOCSS.BLL
{
	/// <summary>
	/// Course
	/// </summary>
	public partial class Course
	{
		private readonly ITCastOCSS.DAL.Course dal=new ITCastOCSS.DAL.Course();
		public Course()
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
		public bool Exists(int CID)
		{
			return dal.Exists(CID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ITCastOCSS.Model.Course model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ITCastOCSS.Model.Course model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CID)
		{
			
			return dal.Delete(CID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CIDlist )
		{
			return dal.DeleteList(CIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ITCastOCSS.Model.Course GetModel(int CID)
		{
			
			return dal.GetModel(CID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ITCastOCSS.Model.Course GetModelByCache(int CID)
		{
			
			string CacheKey = "CourseModel-" + CID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ITCastOCSS.Model.Course)objModel;
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
		public List<ITCastOCSS.Model.Course> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ITCastOCSS.Model.Course> DataTableToList(DataTable dt)
		{
			List<ITCastOCSS.Model.Course> modelList = new List<ITCastOCSS.Model.Course>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ITCastOCSS.Model.Course model;
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

