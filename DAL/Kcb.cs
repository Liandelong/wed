using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
    /// <summary>
    /// 数据访问类:Kcb
    /// </summary>
    public partial class Kcb
    {
        public Kcb()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string CName, string Grade, string Week, string Timeperiod, int MaxNum, int ActualNum, string TNo, string TName, int TID, int CID, int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Kcb");
            strSql.Append(" where CName=@CName and Grade=@Grade and Week=@Week and Timeperiod=@Timeperiod and MaxNum=@MaxNum and ActualNum=@ActualNum and TNo=@TNo and TName=@TName and TID=@TID and CID=@CID and ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@TNo", SqlDbType.Char,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4)            };
            parameters[0].Value = CName;
            parameters[1].Value = Grade;
            parameters[2].Value = Week;
            parameters[3].Value = Timeperiod;
            parameters[4].Value = MaxNum;
            parameters[5].Value = ActualNum;
            parameters[6].Value = TNo;
            parameters[7].Value = TName;
            parameters[8].Value = TID;
            parameters[9].Value = CID;
            parameters[10].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ITCastOCSS.Model.Kcb model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Kcb(");
            strSql.Append("CName,Grade,Week,Timeperiod,MaxNum,ActualNum,TNo,TName,TID,CID,ID)");
            strSql.Append(" values (");
            strSql.Append("@CName,@Grade,@Week,@Timeperiod,@MaxNum,@ActualNum,@TNo,@TName,@TID,@CID,@ID)");
            SqlParameter[] parameters = {
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@TNo", SqlDbType.Char,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.CName;
            parameters[1].Value = model.Grade;
            parameters[2].Value = model.Week;
            parameters[3].Value = model.Timeperiod;
            parameters[4].Value = model.MaxNum;
            parameters[5].Value = model.ActualNum;
            parameters[6].Value = model.TNo;
            parameters[7].Value = model.TName;
            parameters[8].Value = model.TID;
            parameters[9].Value = model.CID;
            parameters[10].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ITCastOCSS.Model.Kcb model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Kcb set ");
            strSql.Append("CName=@CName,");
            strSql.Append("Grade=@Grade,");
            strSql.Append("Week=@Week,");
            strSql.Append("Timeperiod=@Timeperiod,");
            strSql.Append("MaxNum=@MaxNum,");
            strSql.Append("ActualNum=@ActualNum,");
            strSql.Append("TNo=@TNo,");
            strSql.Append("TName=@TName,");
            strSql.Append("TID=@TID,");
            strSql.Append("CID=@CID,");
            strSql.Append("ID=@ID");
            strSql.Append(" where CName=@CName and Grade=@Grade and Week=@Week and Timeperiod=@Timeperiod and MaxNum=@MaxNum and ActualNum=@ActualNum and TNo=@TNo and TName=@TName and TID=@TID and CID=@CID and ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@TNo", SqlDbType.Char,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.CName;
            parameters[1].Value = model.Grade;
            parameters[2].Value = model.Week;
            parameters[3].Value = model.Timeperiod;
            parameters[4].Value = model.MaxNum;
            parameters[5].Value = model.ActualNum;
            parameters[6].Value = model.TNo;
            parameters[7].Value = model.TName;
            parameters[8].Value = model.TID;
            parameters[9].Value = model.CID;
            parameters[10].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string CName, string Grade, string Week, string Timeperiod, int MaxNum, int ActualNum, string TNo, string TName, int TID, int CID, int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Kcb ");
            strSql.Append(" where CName=@CName and Grade=@Grade and Week=@Week and Timeperiod=@Timeperiod and MaxNum=@MaxNum and ActualNum=@ActualNum and TNo=@TNo and TName=@TName and TID=@TID and CID=@CID and ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@TNo", SqlDbType.Char,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4)            };
            parameters[0].Value = CName;
            parameters[1].Value = Grade;
            parameters[2].Value = Week;
            parameters[3].Value = Timeperiod;
            parameters[4].Value = MaxNum;
            parameters[5].Value = ActualNum;
            parameters[6].Value = TNo;
            parameters[7].Value = TName;
            parameters[8].Value = TID;
            parameters[9].Value = CID;
            parameters[10].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.Kcb GetModel(string CName, string Grade, string Week, string Timeperiod, int MaxNum, int ActualNum, string TNo, string TName, int TID, int CID, int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CName,Grade,Week,Timeperiod,MaxNum,ActualNum,TNo,TName,TID,CID,ID from Kcb ");
            strSql.Append(" where CName=@CName and Grade=@Grade and Week=@Week and Timeperiod=@Timeperiod and MaxNum=@MaxNum and ActualNum=@ActualNum and TNo=@TNo and TName=@TName and TID=@TID and CID=@CID and ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,10),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@TNo", SqlDbType.Char,4),
                    new SqlParameter("@TName", SqlDbType.NVarChar,8),
                    new SqlParameter("@TID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4)            };
            parameters[0].Value = CName;
            parameters[1].Value = Grade;
            parameters[2].Value = Week;
            parameters[3].Value = Timeperiod;
            parameters[4].Value = MaxNum;
            parameters[5].Value = ActualNum;
            parameters[6].Value = TNo;
            parameters[7].Value = TName;
            parameters[8].Value = TID;
            parameters[9].Value = CID;
            parameters[10].Value = ID;

            ITCastOCSS.Model.Kcb model = new ITCastOCSS.Model.Kcb();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ITCastOCSS.Model.Kcb DataRowToModel(DataRow row)
        {
            ITCastOCSS.Model.Kcb model = new ITCastOCSS.Model.Kcb();
            if (row != null)
            {
                if (row["CName"] != null)
                {
                    model.CName = row["CName"].ToString();
                }
                if (row["Grade"] != null)
                {
                    model.Grade = row["Grade"].ToString();
                }
                if (row["Week"] != null)
                {
                    model.Week = row["Week"].ToString();
                }
                if (row["Timeperiod"] != null)
                {
                    model.Timeperiod = row["Timeperiod"].ToString();
                }
                if (row["MaxNum"] != null && row["MaxNum"].ToString() != "")
                {
                    model.MaxNum = int.Parse(row["MaxNum"].ToString());
                }
                if (row["ActualNum"] != null && row["ActualNum"].ToString() != "")
                {
                    model.ActualNum = int.Parse(row["ActualNum"].ToString());
                }
                if (row["TNo"] != null)
                {
                    model.TNo = row["TNo"].ToString();
                }
                if (row["TName"] != null)
                {
                    model.TName = row["TName"].ToString();
                }
                if (row["TID"] != null && row["TID"].ToString() != "")
                {
                    model.TID = int.Parse(row["TID"].ToString());
                }
                if (row["CID"] != null && row["CID"].ToString() != "")
                {
                    model.CID = int.Parse(row["CID"].ToString());
                }
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CName,Grade,Week,Timeperiod,MaxNum,ActualNum,TNo,TName,TID,CID,ID ");
            strSql.Append(" FROM Kcb ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" CName,Grade,Week,Timeperiod,MaxNum,ActualNum,TNo,TName,TID,CID,ID ");
            strSql.Append(" FROM Kcb ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Kcb ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from Kcb T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Kcb";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

