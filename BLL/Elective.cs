using ITCastOCSS.Model;
using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
namespace ITCastOCSS.BLL
{
	/// <summary>
	/// Elective
	/// </summary>
	public partial class Elective
	{
		private readonly ITCastOCSS.DAL.Elective dal=new ITCastOCSS.DAL.Elective();
		public Elective()
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
		public bool Exists(int EID)
		{
			return dal.Exists(EID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ITCastOCSS.Model.Elective model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ITCastOCSS.Model.Elective model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int EID)
		{
			
			return dal.Delete(EID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string EIDlist )
		{
			return dal.DeleteList(EIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ITCastOCSS.Model.Elective GetModel(int EID)
		{
			
			return dal.GetModel(EID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public ITCastOCSS.Model.Elective GetModelByCache(int EID)
		{
			
			string CacheKey = "ElectiveModel-" + EID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(EID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ITCastOCSS.Model.Elective)objModel;
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
		public List<ITCastOCSS.Model.Elective> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ITCastOCSS.Model.Elective> DataTableToList(DataTable dt)
		{
			List<ITCastOCSS.Model.Elective> modelList = new List<ITCastOCSS.Model.Elective>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ITCastOCSS.Model.Elective model;
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
        public  bool input(int eid,double score)
        {
           return  dal.input(eid, score) > 0;
        }
        public bool Xuanke(int sid,int cid)
        {
            return dal.Xuanke(sid, cid) > 0;
        }
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

