using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
	/// <summary>
	/// 数据访问类:Elective
	/// </summary>
	public partial class Elective
	{
		public Elective()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("EID", "Elective"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int EID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Elective");
			strSql.Append(" where EID=@EID");
			SqlParameter[] parameters = {
					new SqlParameter("@EID", SqlDbType.Int,4)
			};
			parameters[0].Value = EID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ITCastOCSS.Model.Elective model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Elective(");
			strSql.Append("SID,CID,Score)");
			strSql.Append(" values (");
			strSql.Append("@SID,@CID,@Score)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4),
					new SqlParameter("@CID", SqlDbType.Int,4),
					new SqlParameter("@Score", SqlDbType.Float,8)};
			parameters[0].Value = model.SID;
			parameters[1].Value = model.CID;
			parameters[2].Value = model.Score;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ITCastOCSS.Model.Elective model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Elective set ");
			strSql.Append("SID=@SID,");
			strSql.Append("CID=@CID,");
			strSql.Append("Score=@Score");
			strSql.Append(" where EID=@EID");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4),
					new SqlParameter("@CID", SqlDbType.Int,4),
					new SqlParameter("@Score", SqlDbType.Float,8),
					new SqlParameter("@EID", SqlDbType.Int,4)};
			parameters[0].Value = model.SID;
			parameters[1].Value = model.CID;
			parameters[2].Value = model.Score;
			parameters[3].Value = model.EID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int EID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Elective ");
			strSql.Append(" where EID=@EID");
			SqlParameter[] parameters = {
					new SqlParameter("@EID", SqlDbType.Int,4)
			};
			parameters[0].Value = EID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string EIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Elective ");
			strSql.Append(" where EID in ("+EIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public ITCastOCSS.Model.Elective GetModel(int EID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EID,SID,CID,Score from Elective ");
			strSql.Append(" where EID=@EID");
			SqlParameter[] parameters = {
					new SqlParameter("@EID", SqlDbType.Int,4)
			};
			parameters[0].Value = EID;

			ITCastOCSS.Model.Elective model=new ITCastOCSS.Model.Elective();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public ITCastOCSS.Model.Elective DataRowToModel(DataRow row)
		{
			ITCastOCSS.Model.Elective model=new ITCastOCSS.Model.Elective();
			if (row != null)
			{
				if(row["EID"]!=null && row["EID"].ToString()!="")
				{
					model.EID=int.Parse(row["EID"].ToString());
				}
				if(row["SID"]!=null && row["SID"].ToString()!="")
				{
					model.SID=int.Parse(row["SID"].ToString());
				}
				if(row["CID"]!=null && row["CID"].ToString()!="")
				{
					model.CID=int.Parse(row["CID"].ToString());
				}
				if(row["Score"]!=null && row["Score"].ToString()!="")
				{
					model.Score=decimal.Parse(row["Score"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select EID,SID,CID,Score ");
			strSql.Append(" FROM Elective ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" EID,SID,CID,Score ");
			strSql.Append(" FROM Elective ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Elective ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.EID desc");
			}
			strSql.Append(")AS Row, T.*  from Elective T ");
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
			parameters[0].Value = "Elective";
			parameters[1].Value = "EID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
        public int input(int eid,double score)
        {
            string sql = string.Format( "update Elective set Score={0} where eid={1}", score,eid);
            return DbHelperSQL.ExecuteSql(sql);
        }


        public int Xuanke(int sid,int cid,int tid)
        {
            string sql =string.Format("update Teaching set ActualNum=ActualNum+1 where cid={0} and tid={1}; insert into Elective(sid,cid) values({2},{3})",cid,tid, sid,cid);
            //   string sql = string.Format("delete  from Elective where eid=14");
             return DbHelperSQL.ExecuteSql(sql);
           //int r= DBHelper.getInstance().UpdateSql(sql);
          
           // DBHelper.getInstance().CloseConnetcion();
            
           // return r;
        }
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

