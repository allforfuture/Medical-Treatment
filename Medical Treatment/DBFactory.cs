﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;

using Npgsql;

namespace Medical_Treatment
{
    public class DBFactory
    {
        static string DbConnectstring = ConfigurationManager.ConnectionStrings["pqmcon"].ToString();
        NpgsqlConnection con;

        public int ExecuteSQL(string sql)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        public void ExecuteDataTable(string sql, ref DataTable dt)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                try
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
            }
        }

        public void ExecuteDataTable(string sql, ref DataTable dt, ref bool IsNotCatch)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                try
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                    da.Fill(dt);
                    IsNotCatch = true;
                }
                catch (Exception ex)
                {
                    IsNotCatch = false;
                    //设置自动关闭
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
            }
        }

        public void ExecuteTran(ref DataTable dt)
        {
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                NpgsqlTransaction tran;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                tran = cmd.Transaction;
                try
                {
                    string newRecordId = GetNewRecordId();
                    cmd.CommandText = "insert into t_record values('" + newRecordId + "','" + dt.Rows[0]["holder_dept"].ToString() + "','" + dt.Rows[0]["holder_dept"].ToString() + "'," +
                        "'" + dt.Rows[0]["holder_emp"].ToString() + "','" + dt.Rows[0]["holder_name"].ToString() + "','" + dt.Rows[0]["register_emp"].ToString() + "',getdate(),'',0,'n','" + dt.Rows[0]["reason"].ToString() + "'";
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        cmd = new NpgsqlCommand("insert into t_module values('" + newRecordId + "','" + dt.Rows[0]["serial_cd"].ToString() + "','" + dt.Rows[0]["model"].ToString() + "')", con);
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                }
            }
        }

        //public bool ExecuteObject(ref RecordInfo info)
        //{
        //	using (con = new NpgsqlConnection(DbConnectstring))
        //	{
        //		con.Open();
        //		NpgsqlTransaction tran = con.BeginTransaction();
        //		NpgsqlCommand cmd = new NpgsqlCommand();
        //		cmd.Connection = con;
        //		try
        //		{
        //			// modify date:2018-06-05 将register_date的时间改为数据的时间
        //			string newRecordId = GetNewRecordId();
        //			info.record_id = newRecordId;
        //			cmd.CommandText = "insert into t_record(record_id,site,holder_dept,holder_emp,holder_name,register_emp,register_date,type,category_id,category_cd) values('" + newRecordId + "','" + info.site + "','" + info.holder_dept + "'," +
        //				"'" + info.holder_emp + "','" + info.holder_name + "','" + info.register_emp + "',now(),'" + info.type + "','" + info.statue + "','" + info.reason + "')";
        //			cmd.ExecuteNonQuery();
        //			//事务
        //			foreach (serial se in info.serials)
        //			{
        //				cmd.CommandText = "insert into t_module values('" + newRecordId + "','" + se.serial_cd + "','" + se.model + "','" + se.category + "')";
        //				cmd.ExecuteNonQuery();
        //			}
        //			tran.Commit();
        //			return true;
        //		}
        //		catch
        //		{
        //			tran.Rollback();
        //			return false;
        //		}
        //	}
        //}

        private string GetNewRecordId()
        {
            string newid = "";
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                con.Open();
                string sql0 = "LOCK TABLE t_record IN ACCESS EXCLUSIVE MODE";
                string sql1 = "select MAX(record_id) from t_record where register_date >='" + DateTime.Now.ToString("yyyy/MM/dd 00:00:00") + "'";
                NpgsqlTransaction tran = con.BeginTransaction();
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql0, con);
                    cmd.ExecuteNonQuery();
                    cmd = new NpgsqlCommand(sql1, con);
                    //运行标量cmd.ExecuteScalar(),获取select的值
                    newid = cmd.ExecuteScalar().ToString();
                    if (newid == string.Empty)
                    {
                        newid = DateTime.Now.ToString("yyyyMMdd") + "P" + "001";
                    }
                    else
                    {
                        string tmp = "00" + (int.Parse(newid.Substring(9, 3)) + 1).ToString();
                        newid = newid.Substring(0, 8) + "P" + tmp.Substring(tmp.Length - 3, 3);
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                }
            }
            return newid;
        }

        public string GetNewCartonId()
        {
            string newid = "";
            using (con = new NpgsqlConnection(DbConnectstring))
            {
                con.Open();
                string sql0 = "LOCK TABLE t_carton IN ACCESS EXCLUSIVE MODE";
                string sql1 = "select MAX(carton_id) from t_carton where create_date >='" + DateTime.Now.ToString("yyyy/MM/dd 00:00:00") + "'";
                NpgsqlTransaction tran = con.BeginTransaction();
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql0, con);
                    cmd.ExecuteNonQuery();
                    cmd = new NpgsqlCommand(sql1, con);
                    //运行标量cmd.ExecuteScalar(),获取select的值
                    newid = cmd.ExecuteScalar().ToString();
                    if (newid == string.Empty)
                    {
                        newid = DateTime.Now.ToString("yyyyMMdd") + "C" + "001";
                    }
                    else
                    {
                        string tmp = "00" + (int.Parse(newid.Substring(9, 3)) + 1).ToString();
                        newid = newid.Substring(0, 8) + "C" + tmp.Substring(tmp.Length - 3, 3);
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                }
            }
            return newid;
        }
    }
}
