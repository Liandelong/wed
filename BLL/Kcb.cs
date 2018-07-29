using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ITCastOCSS.Model;
using ITCastOCSS.DAL;
namespace ITCastOCSS.BLL
{
    /// <summary>
    /// Kcb
    /// </summary>
    public partial class Kcb
    {
        private readonly ITCastOCSS.DAL.Kcb dal = new ITCastOCSS.DAL.Kcb();
        public Kcb()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string CName, string Grade, string Week, string Timeperiod, int MaxNum, int ActualNum, string TNo, string TName, int TID, int CID, int ID)
        {
            return dal.Exists(CName, Grade, Week, Timeperiod, MaxNum, ActualNum, TNo, TName, TID, CID, ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ITCastOCSS.Model.Kcb model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ITCastOCSS.Model.Kcb model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string CName, string Grade, string Week, string Timeperiod, int MaxNum, int ActualNum, string TNo, string TName, int TID, int CID, int ID)
        {

            return dal.Delete(CName, Grade, Week, Timeperiod, MaxNum, ActualNum, TNo, TName, TID, CID, ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.Kcb GetModel(string CName, string Grade, string Week, string Timeperiod, int MaxNum, int ActualNum, string TNo, string TName, int TID, int CID, int ID)
        {

            return dal.GetModel(CName, Grade, Week, Timeperiod, MaxNum, ActualNum, TNo, TName, TID, CID, ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public ITCastOCSS.Model.Kcb GetModelByCache(string CName, string Grade, string Week, string Timeperiod, int MaxNum, int ActualNum, string TNo, string TName, int TID, int CID, int ID)
        {

            string CacheKey = "KcbModel-" + CName + Grade + Week + Timeperiod + MaxNum + ActualNum + TNo + TName + TID + CID + ID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(CName, Grade, Week, Timeperiod, MaxNum, ActualNum, TNo, TName, TID, CID, ID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (ITCastOCSS.Model.Kcb)objModel;
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
        public List<ITCastOCSS.Model.Kcb> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ITCastOCSS.Model.Kcb> DataTableToList(DataTable dt)
        {
            List<ITCastOCSS.Model.Kcb> modelList = new List<ITCastOCSS.Model.Kcb>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ITCastOCSS.Model.Kcb model;
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
        public List<ITCastOCSS.Model.Kcb> GetModelListByTID(int id)
        {
            return GetModelList("tid="+id);
        }
        #endregion  ExtensionMethod
    }
}

