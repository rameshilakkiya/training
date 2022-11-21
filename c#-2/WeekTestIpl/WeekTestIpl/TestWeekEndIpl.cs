using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WeekTestIpl
{
   
    internal class TestWeekEndIpl
    {
        //bool flag = false;
        internal static void Connection()
        {
            /*String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);*/
            
            Console.WriteLine("What you want to do?");
            int option;
             bool flag=true;
            do
            {
                if(flag==true)
                Console.WriteLine("1)Add Player,2)Display Players,3)Play Match,4)Delete Player,5)show Orange Cap,6)show purple cap,7)Exit");
                option = Convert.ToInt32(Console.ReadLine());          
                switch (option)
                {  
                    case 1:
                            
                            addplayer();
                            break;
                        case 2:
                            displayPlayers();
                            break;

                        case 3:
                            playmatch();
                           
                            break;
                        case 4:
                            delete();
                            break;
                        case 5:
                            orange();
                            break;
                        case 6:
                            purple();
                            break;
                    case 7:
                        exit();
                        break;
                        
                    default:
                            Console.WriteLine("Give a proper option");
                        
                            break;
                }
            } while (option != 6) ;
            
                    
        }
        internal static void exit()
        {
            bool flag = false;
        }
           
        internal static void addplayer()
        {
           
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                   
                    Console.Write("Enter PlayerName: ");
                    String name = Console.ReadLine();
                    Console.Write("Enter Howmany matches played: ");
                    int matches = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Howmany Runs Scored: ");
                    int run = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Howmany wickets : ");
                    int wicket = Convert.ToInt32(Console.ReadLine());
                    String query = "insert into iplplayer values(@name,@matches,@run,@wicket)";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@matches", matches);
                    cmd.Parameters.AddWithValue("@run", run);
                    cmd.Parameters.AddWithValue("@wicket", wicket);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    
                    if (status > 0)
                    {
                        Console.WriteLine("Insertion Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Insertion Failed");
                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        internal static void displayPlayers()
        {
           
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using(con = new SqlConnection(cs))
                {
                   
                    String query = "select * from iplplayer";
                    SqlCommand cmd=new SqlCommand(query,con);
                    con.Open();
                    SqlDataReader dr=cmd.ExecuteReader();
                    
                    
                    while (dr.Read())
                    {
                        Console.WriteLine("PlayerId=" + dr[0]+"PlayerName= " + dr[1]+"Matches= " + dr[2]+"Runs= " + dr[3] + "Wickets=" + dr[4]);
                    }
                   
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        internal static void playmatch()
        {
            
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
           
            try
            {
                using (con = new SqlConnection(cs))
                {
                    
                    Console.Write("Enter MatchID: ");
                    int mid = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter PlayerId: ");
                    int playerid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter MatchDate: ");
                    DateTime mdate = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Location : ");
                    String location = Console.ReadLine();
                    Console.Write("Enter Runs: ");
                    int runs = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter Wicket: ");
                    int wickets = Convert.ToInt32(Console.ReadLine());
                    //String query = "update iplmatches set matchid=@mid,playerid=@pid,matchdate=@mdate,location=@location,runs=@run,wickets=@wicket";
                    String query= "insert into iplmatches values(@mid,@playerid,@mdate,@location,@runs,@wickets)";
                    String qu= "update iplplayer set matches=matches+1,runs=runs+@runs,wickets=wickets+@wickets where playerid=@playerid";
                    //String q = "select * from iplplayer";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@mid", mid);
                    cmd.Parameters.AddWithValue("@playerid", playerid);
                    cmd.Parameters.AddWithValue("@mdate", mdate);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@runs", runs);
                    cmd.Parameters.AddWithValue("@wickets", wickets);
                   
                    SqlCommand cmd1 = new SqlCommand(qu, con);
                    cmd1.Parameters.AddWithValue("@playerid", playerid);
                    cmd1.Parameters.AddWithValue("@runs", runs);
                    cmd1.Parameters.AddWithValue("@wickets", wickets);
                    //cmd1.Parameters.AddWithValue("@playerid", playerid);
                    con.Open();
                    int status = cmd.ExecuteNonQuery();
                    int status1 = cmd1.ExecuteNonQuery();
                    if (status > 0)
                    {
                        Console.WriteLine("Insertion in IPLMatch Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Insertion in IPLMatch Failed");
                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        internal static void orange()
        {
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    Console.Write("Enter year for find Orange Holder: ");
                    int yea = Convert.ToInt16(Console.ReadLine());
                    String query = "select playerid,sum(runs) as totalruns from iplmatches where years = @yea group by playerid order by totalruns desc";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@yea", yea);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("PlayerId=" + dr[0] +" "+ "Runs= " + dr[1]);
                        //Console.WriteLine("PlayerId=" + dr[0] + "PlayerName= " + dr[1] + "Matches= " + dr[2] + "Runs= " + dr[3] + "Wickets=" + dr[4]);
                    }
                    //int status = cmd.ExecuteNonQuery();
                   /* if (status > 0)
                    {
                        Console.WriteLine("Orange Cap Holder");
                    }
                    else
                    {
                        Console.WriteLine("NOOO");
                    }*/
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        internal static void purple()
        {
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    Console.Write("Enter year for find Orange Holder: ");
                    int yea = Convert.ToInt16(Console.ReadLine());
                    String query = "select playerid,sum(wickets) as totalwickets from iplmatches where years = @yea group by playerid order by totalwickets desc";
;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@yea", yea);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("PlayerId=" + dr[0] + " " + "Wickets= " + dr[1]);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        internal static void delete()
        {
           
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    
                    Console.Write("Enter Id for deletion:");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    String query = "delete from iplmatches where playerid=@pid";
                    String qu = "delete from iplplayer where playerid=@pid";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    SqlCommand cmd2 = new SqlCommand(qu, con);
                    cmd1.Parameters.AddWithValue("@pid", pid);
                    cmd2.Parameters.AddWithValue("@pid", pid);
                    con.Open();
                    int status = cmd1.ExecuteNonQuery();
                    if (status > 0)
                    {
                        Console.WriteLine("Deletion Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Deletion Failed");
                    }
                    

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }


    }
}
