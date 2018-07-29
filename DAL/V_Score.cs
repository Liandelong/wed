using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
    /// <summary>
    /// 数据访问类:v_Score
    /// </summary>
    public partial class v_Score
    {
        public v_Score()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int SID, string SNo, string SName, int CID, int Credit, string CName, string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, decimal Score, int EID, int TID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from v_Score");
            strSql.Append(" where SID=@SID and SNo=@SNo and SName=@SName and CID=@CID and Credit=@Credit and CName=@CName and Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and Score=@Score and EID=@EID and TID=@TID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@SID", SqlDbType.Int,4),
                    new SqlParameter("@SNo", SqlDbType.Char,9),
                    new SqlParameter("@SName", SqlDbType.NVarChar,8),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@Score", SqlDbType.Float,8),
                    new SqlParameter("@EID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4)           };
            parameters[0].Value = SID;
            parameters[1].Value = SNo;
            parameters[2].Value = SName;
            parameters[3].Value = CID;
            parameters[4].Value = Credit;
            parameters[5].Value = CName;
            parameters[6].Value = Week;
            parameters[7].Value = Timeperiod;
            parameters[8].Value = Place;
            parameters[9].Value = MaxNum;
            parameters[10].Value = ActualNum;
            parameters[11].Value = Score;
            parameters[12].Value = EID;
            parameters[13].Value = TID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ITCastOCSS.Model.v_Score model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into v_Score(");
            strSql.Append("SID,SNo,SName,CID,Credit,CName,Week,Timeperiod,Place,MaxNum,ActualNum,Score,EID,TID)");
            strSql.Append(" values (");
            strSql.Append("@SID,@SNo,@SName,@CID,@Credit,@CName,@Week,@Timeperiod,@Place,@MaxNum,@ActualNum,@Score,@EID,@TID)");
            SqlParameter[] parameters = {
                    new SqlParameter("@SID", SqlDbType.Int,4),
                    new SqlParameter("@SNo", SqlDbType.Char,9),
                    new SqlParameter("@SName", SqlDbType.NVarChar,8),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@Score", SqlDbType.Float,8),
                    new SqlParameter("@EID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4)};
            parameters[0].Value = model.SID;
            parameters[1].Value = model.SNo;
            parameters[2].Value = model.SName;
            parameters[3].Value = model.CID;
            parameters[4].Value = model.Credit;
            parameters[5].Value = model.CName;
            parameters[6].Value = model.Week;
            parameters[7].Value = model.Timeperiod;
            parameters[8].Value = model.Place;
            parameters[9].Value = model.MaxNum;
            parameters[10].Value = model.ActualNum;
            parameters[11].Value = model.Score;
            parameters[12].Value = model.EID;
            parameters[13].Value = model.TID;

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
        public bool Update(ITCastOCSS.Model.v_Score model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update v_Score set ");
            strSql.Append("SID=@SID,");
            strSql.Append("SNo=@SNo,");
            strSql.Append("SName=@SName,");
            strSql.Append("CID=@CID,");
            strSql.Append("Credit=@Credit,");
            strSql.Append("CName=@CName,");
            strSql.Append("Week=@Week,");
            strSql.Append("Timeperiod=@Timeperiod,");
            strSql.Append("Place=@Place,");
            strSql.Append("MaxNum=@MaxNum,");
            strSql.Append("ActualNum=@ActualNum,");
            strSql.Append("Score=@Score,");
            strSql.Append("EID=@EID,");
            strSql.Append("TID=@TID");
            strSql.Append(" where SID=@SID and SNo=@SNo and SName=@SName and CID=@CID and Credit=@Credit and CName=@CName and Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and Score=@Score and EID=@EID and TID=@TID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@SID", SqlDbType.Int,4),
                    new SqlParameter("@SNo", SqlDbType.Char,9),
                    new SqlParameter("@SName", SqlDbType.NVarChar,8),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@Score", SqlDbType.Float,8),
                    new SqlParameter("@EID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4)};
            parameters[0].Value = model.SID;
            parameters[1].Value = model.SNo;
            parameters[2].Value = model.SName;
            parameters[3].Value = model.CID;
            parameters[4].Value = model.Credit;
            parameters[5].Value = model.CName;
            parameters[6].Value = model.Week;
            parameters[7].Value = model.Timeperiod;
            parameters[8].Value = model.Place;
            parameters[9].Value = model.MaxNum;
            parameters[10].Value = model.ActualNum;
            parameters[11].Value = model.Score;
            parameters[12].Value = model.EID;
            parameters[13].Value = model.TID;

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
        public bool Delete(int SID, string SNo, string SName, int CID, int Credit, string CName, string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, decimal Score, int EID, int TID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from v_Score ");
            strSql.Append(" where SID=@SID and SNo=@SNo and SName=@SName and CID=@CID and Credit=@Credit and CName=@CName and Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and Score=@Score and EID=@EID and TID=@TID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@SID", SqlDbType.Int,4),
                    new SqlParameter("@SNo", SqlDbType.Char,9),
                    new SqlParameter("@SName", SqlDbType.NVarChar,8),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@Score", SqlDbType.Float,8),
                    new SqlParameter("@EID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4)           };
            parameters[0].Value = SID;
            parameters[1].Value = SNo;
            parameters[2].Value = SName;
            parameters[3].Value = CID;
            parameters[4].Value = Credit;
            parameters[5].Value = CName;
            parameters[6].Value = Week;
            parameters[7].Value = Timeperiod;
            parameters[8].Value = Place;
            parameters[9].Value = MaxNum;
            parameters[10].Value = ActualNum;
            parameters[11].Value = Score;
            parameters[12].Value = EID;
            parameters[13].Value = TID;

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
        public ITCastOCSS.Model.v_Score GetModel(int SID, string SNo, string SName, int CID, int Credit, string CName, string Week, string Timeperiod, string Place, int MaxNum, int ActualNum, decimal Score, int EID, int TID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SID,SNo,SName,CID,Credit,CName,Week,Timeperiod,Place,MaxNum,ActualNum,Score,EID,TID from v_Score ");
            strSql.Append(" where SID=@SID and SNo=@SNo and SName=@SName and CID=@CID and Credit=@Credit and CName=@CName and Week=@Week and Timeperiod=@Timeperiod and Place=@Place and MaxNum=@MaxNum and ActualNum=@ActualNum and Score=@Score and EID=@EID and TID=@TID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@SID", SqlDbType.Int,4),
                    new SqlParameter("@SNo", SqlDbType.Char,9),
                    new SqlParameter("@SName", SqlDbType.NVarChar,8),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@Credit", SqlDbType.Int,4),
                    new SqlParameter("@CName", SqlDbType.NVarChar,20),
                    new SqlParameter("@Week", SqlDbType.NVarChar,20),
                    new SqlParameter("@Timeperiod", SqlDbType.NVarChar,20),
                    new SqlParameter("@Place", SqlDbType.NVarChar,20),
                    new SqlParameter("@MaxNum", SqlDbType.Int,4),
                    new SqlParameter("@ActualNum", SqlDbType.Int,4),
                    new SqlParameter("@Score", SqlDbType.Float,8),
                    new SqlParameter("@EID", SqlDbType.Int,4),
                    new SqlParameter("@TID", SqlDbType.Int,4)           };
            parameters[0].Value = SID;
            parameters[1].Value = SNo;
            parameters[2].Value = SName;
            parameters[3].Value = CID;
            parameters[4].Value = Credit;
            parameters[5].Value = CName;
            parameters[6].Value = Week;
            parameters[7].Value = Timeperiod;
            parameters[8].Value = Place;
            parameters[9].Value = MaxNum;
            parameters[10].Value = ActualNum;
            parameters[11].Value = Score;
            parameters[12].Value = EID;
            parameters[13].Value = TID;

            ITCastOCSS.Model.v_Score model = new ITCastOCSS.Model.v_Score();
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
        public ITCastOCSS.Model.v_Score DataRowToModel(DataRow row)
        {
            ITCastOCSS.Model.v_Score model = new ITCastOCSS.Model.v_Score();
            if (row != null)
            {
                if (row["SID"] != null && row["SID"].ToString() != "")
                {
                    model.SID = int.Parse(row["SID"].ToString());
                }
                if (row["SNo"] != null)
                {
                    model.SNo = row["SNo"].ToString();
                }
                if (row["SName"] != null)
                {
                    model.SName = row["SName"].ToString();
                }
                if (row["CID"] != null && row["CID"].ToString() != "")
                {
                    model.CID = int.Parse(row["CID"].ToString());
                }
                if (row["Credit"] != null && row["Credit"].ToString() != "")
                {
                    model.Credit = int.Parse(row["Credit"].ToString());
                }
                if (row["CName"] != null)
                {
                    model.CName = row["CName"].ToString();
                }
                if (row["Week"] != null)
                {
                    model.Week = row["Week"].ToString();
                }
                if (row["Timeperiod"] != null)
                {
                    model.Timeperiod = row["Timeperiod"].ToString();
                }
                if (row["Place"] != null)
                {
                    model.Place = row["Place"].ToString();
                }
                if (row["MaxNum"] != null && row["MaxNum"].ToString() != "")
                {
                    model.MaxNum = int.Parse(row["MaxNum"].ToString());
                }
                if (row["ActualNum"] != null && row["ActualNum"].ToString() != "")
                {
                    model.ActualNum = int.Parse(row["ActualNum"].ToString());
                }
                if (row["Score"] != null && row["Score"].ToString() != "")
                {
                    model.Score = decimal.Parse(row["Score"].ToString());
                }
                if (row["EID"] != null && row["EID"].ToString() != "")
                {
                    model.EID = int.Parse(row["EID"].ToString());
                }
                if (row["TID"] != null && row["TID"].ToString() != "")
                {
                    model.TID = int.Parse(row["TID"].ToString());
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
            strSql.Append("select SID,SNo,SName,CID,Credit,CName,Week,Timeperiod,Place,MaxNum,ActualNum,Score,EID,TID ");
            strSql.Append(" FROM v_Score ");
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
            strSql.Append(" SID,SNo,SName,CID,Credit,CName,Week,Timeperiod,Place,MaxNum,ActualNum,Score,EID,TID ");
            strSql.Append(" FROM v_Score ");
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
            strSql.Append("select count(1) FROM v_Score ");
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
                strSql.Append("order by T.TID desc");
            }
            strSql.Append(")AS Row, T.*  from v_Score T ");
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
			parameters[0].Value = "v_Score";
			parameters[1].Value = "TID";
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

