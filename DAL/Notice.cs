using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace ITCastOCSS.DAL
{
	/// <summary>
	/// 数据访问类:Notice
	/// </summary>
	public partial class Notice
	{
		public Notice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("NID", "Notice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Notice");
			strSql.Append(" where NID=@NID");
			SqlParameter[] parameters = {
					new SqlParameter("@NID", SqlDbType.Int,4)
			};
			parameters[0].Value = NID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ITCastOCSS.Model.Notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Notice(");
			strSql.Append("NTitle,NContent,NAuthor,NTime)");
			strSql.Append(" values (");
			strSql.Append("@NTitle,@NContent,@NAuthor,@NTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@NContent", SqlDbType.NVarChar,-1),
					new SqlParameter("@NAuthor", SqlDbType.NVarChar,20),
					new SqlParameter("@NTime", SqlDbType.DateTime)};
			parameters[0].Value = model.NTitle;
			parameters[1].Value = model.NContent;
			parameters[2].Value = model.NAuthor;
			parameters[3].Value = model.NTime;

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
		public bool Update(ITCastOCSS.Model.Notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Notice set ");
			strSql.Append("NTitle=@NTitle,");
			strSql.Append("NContent=@NContent,");
			strSql.Append("NAuthor=@NAuthor,");
			strSql.Append("NTime=@NTime");
			strSql.Append(" where NID=@NID");
			SqlParameter[] parameters = {
					new SqlParameter("@NTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@NContent", SqlDbType.NVarChar,-1),
					new SqlParameter("@NAuthor", SqlDbType.NVarChar,20),
					new SqlParameter("@NTime", SqlDbType.DateTime),
					new SqlParameter("@NID", SqlDbType.Int,4)};
			parameters[0].Value = model.NTitle;
			parameters[1].Value = model.NContent;
			parameters[2].Value = model.NAuthor;
			parameters[3].Value = model.NTime;
			parameters[4].Value = model.NID;

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
		public bool Delete(int NID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Notice ");
			strSql.Append(" where NID=@NID");
			SqlParameter[] parameters = {
					new SqlParameter("@NID", SqlDbType.Int,4)
			};
			parameters[0].Value = NID;

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
		public bool DeleteList(string NIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Notice ");
			strSql.Append(" where NID in ("+NIDlist + ")  ");
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
		public ITCastOCSS.Model.Notice GetModel(int NID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NID,NTitle,NContent,NAuthor,NTime from Notice ");
			strSql.Append(" where NID=@NID");
			SqlParameter[] parameters = {
					new SqlParameter("@NID", SqlDbType.Int,4)
			};
			parameters[0].Value = NID;

			ITCastOCSS.Model.Notice model=new ITCastOCSS.Model.Notice();
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
		public ITCastOCSS.Model.Notice DataRowToModel(DataRow row)
		{
			ITCastOCSS.Model.Notice model=new ITCastOCSS.Model.Notice();
			if (row != null)
			{
				if(row["NID"]!=null && row["NID"].ToString()!="")
				{
					model.NID=int.Parse(row["NID"].ToString());
				}
				if(row["NTitle"]!=null)
				{
					model.NTitle=row["NTitle"].ToString();
				}
				if(row["NContent"]!=null)
				{
					model.NContent=row["NContent"].ToString();
				}
				if(row["NAuthor"]!=null)
				{
					model.NAuthor=row["NAuthor"].ToString();
				}
				if(row["NTime"]!=null && row["NTime"].ToString()!="")
				{
					model.NTime=DateTime.Parse(row["NTime"].ToString());
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
			strSql.Append("select NID,NTitle,NContent,NAuthor,NTime ");
			strSql.Append(" FROM Notice ");
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
			strSql.Append(" NID,NTitle,NContent,NAuthor,NTime ");
			strSql.Append(" FROM Notice ");
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
			strSql.Append("select count(1) FROM Notice ");
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
				strSql.Append("order by T.NID desc");
			}
			strSql.Append(")AS Row, T.*  from Notice T ");
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
			parameters[0].Value = "Notice";
			parameters[1].Value = "NID";
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

