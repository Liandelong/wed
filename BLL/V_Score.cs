using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ITCastOCSS.Model;
namespace ITCastOCSS.BLL
{
    /// <summary>
    /// v_Score
    /// </summary>
    public partial class v_Score
    {
        private readonly ITCastOCSS.DAL.v_Score dal = new ITCastOCSS.DAL.v_Score();
        public v_Score()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int SID, string SNo, string SName, int CID, int Credit, string CName, string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, decimal Score, int EID, int TID)
        {
            return dal.Exists(SID, SNo, SName, CID, Credit, CName, Week, Timeperiod, Place, MaxNum, ActualNum, Score, EID, TID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ITCastOCSS.Model.v_Score model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ITCastOCSS.Model.v_Score model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int SID, string SNo, string SName, int CID, int Credit, string CName, string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, decimal Score, int EID, int TID)
        {

            return dal.Delete(SID, SNo, SName, CID, Credit, CName, Week, Timeperiod, Place, MaxNum, ActualNum, Score, EID, TID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.v_Score GetModel(int SID, string SNo, string SName, int CID, int Credit, string CName, string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, decimal Score, int EID, int TID)
        {

            return dal.GetModel(SID, SNo, SName, CID, Credit, CName, Week, Timeperiod, Place, MaxNum, ActualNum, Score, EID, TID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ITCastOCSS.Model.v_Score GetModelByCache(int SID, string SNo, string SName, int CID, int Credit, string CName, string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, decimal Score, int EID, int TID)
        {

            string CacheKey = "v_ScoreModel-" + SID + SNo + SName + CID + Credit + CName + Week + Timeperiod + Place + MaxNum + ActualNum + Score + EID + TID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(SID, SNo, SName, CID, Credit, CName, Week, Timeperiod, Place, MaxNum, ActualNum, Score, EID, TID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (ITCastOCSS.Model.v_Score)objModel;
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
        public List<ITCastOCSS.Model.v_Score> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ITCastOCSS.Model.v_Score> DataTableToList(DataTable dt)
        {
            List<ITCastOCSS.Model.v_Score> modelList = new List<ITCastOCSS.Model.v_Score>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ITCastOCSS.Model.v_Score model;
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
        public List<ITCastOCSS.Model.v_Score> GetModelListByTID(int id)
        {
           
            return GetModelList("tid="+id);
        }
        public List<ITCastOCSS.Model.v_Score> GetModelListBysTID(int id)
        {

            return GetModelList("sid=" + id);
        }
        #endregion  ExtensionMethod
    }
}

