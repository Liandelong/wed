using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ITCastOCSS.Model;
namespace ITCastOCSS.BLL
{
    /// <summary>
    /// Xuanke
    /// </summary>
    public partial class Xuanke
    {
        private readonly ITCastOCSS.DAL.Xuanke dal = new ITCastOCSS.DAL.Xuanke();
        public Xuanke()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, int ID, int TID, int CID, string TName, int Credit, string CName, string Term, string Grade)
        {
            return dal.Exists(Week, Timeperiod, Place, MaxNum, ActualNum, ID, TID, CID, TName, Credit, CName, Term, Grade);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ITCastOCSS.Model.Xuanke model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ITCastOCSS.Model.Xuanke model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, int ID, int TID, int CID, string TName, int Credit, string CName, string Term, string Grade)
        {

            return dal.Delete(Week, Timeperiod, Place, MaxNum, ActualNum, ID, TID, CID, TName, Credit, CName, Term, Grade);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.Xuanke GetModel(string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, int ID, int TID, int CID, string TName, int Credit, string CName, string Term, string Grade)
        {

            return dal.GetModel(Week, Timeperiod, Place, MaxNum, ActualNum, ID, TID, CID, TName, Credit, CName, Term, Grade);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ITCastOCSS.Model.Xuanke GetModelByCache(string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, int ID, int TID, int CID, string TName, int Credit, string CName, string Term, string Grade)
        {

            string CacheKey = "XuankeModel-" + Week + Timeperiod + Place + MaxNum + ActualNum + ID + TID + CID + TName + Credit + CName + Term + Grade;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Week, Timeperiod, Place, MaxNum, ActualNum, ID, TID, CID, TName, Credit, CName, Term, Grade);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (ITCastOCSS.Model.Xuanke)objModel;
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ITCastOCSS.Model.Xuanke> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ITCastOCSS.Model.Xuanke> DataTableToList(DataTable dt)
        {
            List<ITCastOCSS.Model.Xuanke> modelList = new List<ITCastOCSS.Model.Xuanke>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ITCastOCSS.Model.Xuanke model;
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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

