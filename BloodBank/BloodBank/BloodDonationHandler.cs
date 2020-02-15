using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    class BloodDonationHandler
    {
        static int i;
        static int k;
        IBloodRecord[] brecord;
        IDonationreacord[] drecord;
        bool chk;
        BloodRecord b = new BloodRecord(0, null, DateTime.Now);
        public BloodDonationHandler(int size)
        {
            brecord = new IBloodRecord[size];
            drecord = new IDonationreacord[size];
            chk = false;
            i = 0;
            k = 0;
        }

        //-----------------------------------------------------------------

        public bool Insertion(IBloodRecord obj,string bloodg)
        {
            
            if(b.BloodgroupChecking(bloodg) ==true)
            {
                brecord[i++] = obj;
                Console.WriteLine("Blood Added Sucessfullllly");
                return true;
            }
            else
            {
                Console.WriteLine("you entered invalid blood group....");
            }
            return false;

        }

        //---------------------------------------------------------------------------------------
        public void displayBloodrecord()
        {
            if(i>0)
            {
                for(int j=0;j<i;j++)
                {
                    Console.WriteLine(brecord[j]);
                }
            }
            else
            {
                Console.WriteLine("blood bank is empty...");
            }
            
        }

        //--------------------------------------------------------------------------------------
        public string search(string bloodgroup)
        {
            if(i>0)
            {
                if (b.BloodgroupChecking(bloodgroup) == true)
                {


                    for (int j = 0; j < i; j++)
                    {
                        if (bloodgroup.Equals(brecord[j].Bloodname))
                        {
                            Console.WriteLine(brecord[j]);
                            chk = true;
                            
;                        }

                    }
                    if (chk == false)
                    {
                        Console.WriteLine("data of blood group[" + bloodgroup + "] not found in blood bank....");
                    }else
                        if(chk==true)
                    {
                        return "yes";
                    }

                }
                else
                {
                    Console.WriteLine("you entered invalid blood group....");
                }
            }
            else
            {
                Console.WriteLine("BloodBank is empty............");
            }
           
            return null;
        }

        //------------------------------------------------------------------------------------------

        public int delete(int bloodId)
        {
            if(i>0)
            {
                for(int j=0;j<i;j++)
                {
                    if(bloodId == brecord[j].Bloodno)
                    {
                        brecord[j] = null;
                        chk = true;
                        Console.WriteLine("\nBLOOD DELETING SUCCESSFULLYYYYYYYYYYYY");
                        break;
                        
                    }
                    else
                    {
                        if((chk=false) && (j==(i-1)))
                            {
                            Console.WriteLine("\nblood not found in bank...");
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("\nBloodBank is empty............");
            }
            return 0;
        }

        //-------------------------------------------------------------------------

        public string deletebloodgroup(string bloodgroup)
        {
            if(i>0)
            {
                if (b.BloodgroupChecking(bloodgroup) == true)
                {
                    for(int j=0;j<i;j++)
                    {
                        if(bloodgroup.Equals(brecord[j].Bloodname))
                        {
                            brecord[j] = null;
                            chk = true;
                            if(j==(i-1))
                            {
                                Console.WriteLine("\nblood deleted sucessfullllllllly");
                            }
                        }
                    }
                    if((chk=false))
                    {
                        Console.WriteLine("\ndata of blood group[" + bloodgroup + "] not found in blood bank....");
                    }
                }
                else
                {
                    Console.WriteLine("\nyou entered invalid blood group....");
                }

            }
            else
            {
                Console.WriteLine("\nBloodBank is empty............");
            }
            return null;
        }

        //--------------------------------------------------------------------------------------

        public void Update(IBloodRecord obj,int bid)
        {
            if(i>0)
            {
                for(int j=0;j<i;j++)
                {
                    if(bid==brecord[j].Bloodno)
                    {
                        brecord[j] = obj;
                        chk = true;
                        Console.WriteLine("\nBlood Updaing Sucessfulllllllllllyyyy");
                        break;

                    }
                }
                if(chk=false)
                {
                    Console.WriteLine("\nblood not found in bank...........s");
                }

            }
            else
            {
                Console.WriteLine("\nBloodBank is empty............");
            }
        }


        //-------------------------------------------------------------------------------------------

        public bool SearchForDonation(int bid)
        {
            if(i>0)
            {
                for(int j=0;j<i;j++)
                {
                    if((bid==brecord[j].Bloodno))
                        {
                        brecord[j] = null;
                        return true;
                       
                        }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry...Blood Bank is Empty...");
            }
            return false;
        }

        //--------------------------------------------------------------------------------------------

        public void DonationInsertion(IDonationreacord obj)
        {
            drecord[k++] = obj;
            Console.WriteLine("Donation record inserted sucessfully..");
        }

        //-------------------------------------------------------------------------------
        public void displayDonation()
        {
            if(k>0)
            {
                for(int j=0;j<k;j++)
                {
                    Console.WriteLine(drecord[j]);
                    
                }
            }
            else
            {
                Console.WriteLine("Donation list is emptyyyyyyyy");
            }
        }
    }
}
