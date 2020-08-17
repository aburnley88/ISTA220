using System;
using System.Threading;

namespace ISTA220Exer3cise06
{
    class Program
    {
        //Parent Method, which is abstract with abstract methods. Parent Method for BaseCommander, AirTrafficController, LoadTeamChief
        abstract class Airman
        {
           public abstract void Salute();
            public abstract void ReturnSalute();
            public abstract void Brief();
        }

        //Parent Method for Crew
        class BaseCommander: Airman
        {
            public override void Salute()
            {
                Console.WriteLine("The commander raises right arm in a sharp a salute.\n");
            }
            public override void ReturnSalute()
            {
                Console.WriteLine("The commander drops right arm swiftly to right side.\n");
            }
            public override void Brief()
            {
                Console.WriteLine("COMMANDER: I need to get the weapons pallet to Yokota Air Bases ASAP!\n");
            }
        }
        //Parent method for the entire load team (Driver, Spotter, Handler, RampController)
        class LoadTeamChief : Airman
        {
            public override void Salute()
            {
                Console.WriteLine("Load Team Chief: Raises right arm in a sharp a salute.\n");
            }
            public override void ReturnSalute()
            {
                Console.WriteLine("Load Team Chief: Drops right arm swiftly to right side.\n");
            }
            public override void Brief()
            {
                Console.WriteLine("LOAD TEAM CHEIF: The commander needs to get the weapons pallet to Yokota Air Bases ASAP!\n" +
                    "\n I need the load hadled safely and expeditiously and I need a perfect SOEs. Use your radios!\n");
            }  
            public void PickLoadTeam()
            {
                Console.WriteLine("LOAD TEAM CHEIF: I'm going to need a couple of drivers, spotters, and a controller to take care of this. \n \n Get it done.\n");
            }
            public void ReceiveMessage()
            {
                Console.WriteLine("LOAD TEAM CHEIF: Received.\n");
            }
        }
        class AirTrafficControl: Airman
        {
            public override void Salute()
            {
                Console.WriteLine("Raises right arm in a sharp a slaute.\n");
            }
            public override void ReturnSalute()
            {
                Console.WriteLine("Drops right arm swiftly to right side.\n");
            }
            public override void Brief()
            {
                Console.WriteLine("AIR TRAFFIC CONTROLLER: Sir, N86685 has departed.\n");
            }
            public void ApproveTakeoff()
            {
                Console.WriteLine("AIR TRAFFIC CONTROLLER: N86685, you're good to depart..\n");
            }
        }

        class Crew: BaseCommander
        {
            public void OpenAirCraftDoor()
            {
                Console.WriteLine("Door opening.\n");
            }
            public void CloseAirCraftDoor()
            {
                Console.WriteLine("Door Closing.\n");
            }
            public void InspectLoad()
            {
                Console.WriteLine("CREW: Just making evering is as it should be.\n");
            }
            public void ApproveLoad()
            {
                Console.WriteLine("CREW: Everything is in accordance with all relevant air regulations.\n");
            }
            public void StartAirCraftEngines()
            {
                Console.WriteLine("VRM VRM VRM VRM.\n");
            }
            public void RequestTakeOff()
            {
                Console.WriteLine("CREW: Air traffic control this is tail number N86685 requesting takeoff.\n");
            }
            public void TakeOff()
            {
                Console.WriteLine("CREW: Taking off. See you next time Control. N86685 out.\n");
            }
        }
        class Driver: LoadTeamChief
        {
            public void GetVehicleForklift()
            {
                Console.WriteLine("Amn Snuffy is getting the Forklift.\n");
            }
            public void GetVehicleKLoader()
            {
                Console.WriteLine("Amn Coo-COo is getting the KLoader.\n");
            }
            public void LoadForkLift()
            {
                Console.WriteLine("The forklift is loaded with the pallet. \n");
            }
            public void DriveToFlightLine()
            {
                Console.WriteLine("heading to the flightline.\n");
            }
            public void ApproachAirCraft()
            {
                Console.WriteLine("Safely approaching aircraft folling spotter directions.\n");
            }
            public void LoadKLoader()
            {
                Console.WriteLine("The K-Loader is loaded with the pallet. \n");
            }
        }
        class RampController: LoadTeamChief
        {
            public void ArriveAtAirCraft()
            {
                Console.WriteLine("RAMP CONTROLLER: Load Cheif, show load team at aircraft now.\n");
            }
            public void StartLoad()
            {
                Console.WriteLine("RAMP CONTROLLER: Load Chief, this is Ramp Control \n" + " begin load time now.\n");
            }
            public void EndLoad()
            {
                Console.WriteLine("RAMP CONTROLLER: Load Chief, this is Ramp Control \n" + " end load time now.");
            }
            public void CallDeparture()
            {
                Console.WriteLine("RAMP CONTROLLER: Load Chief, this is RAMP control \n" + "Show N86685  departed as of now\n");
            }
            public void NotifyCrew()
            {
                Console.WriteLine("RAMP CONTROLLER: Ma'am the load is ready for inpsection\n");
            }
            public void RequestOpenDoor()
            {
                Console.WriteLine("RAMP CONTROLLER: Crew N86685 tihs is Ramp Control.\n" + "We have your load ready now. \n" + "Please open the doors\n");
            }
            public void DismissLoadTeam()
            {
                Console.WriteLine("RAMP CONTROLLER: Ok guys, we're good to go here.\n");
            }
        }
        class Handler: LoadTeamChief
        {
            public void BuildPallet()
            {
                Console.WriteLine("A1C Brown completed the build and paperwork.\n");
            }
            public void PushPallet()
            {
                Console.WriteLine("LOAD TEAM: PUSH....PUSH.....PUUUSHING the pallet onto the plane.\n");
            }
            public void TieDownPallet()
            {
                Console.WriteLine("LOAD TEAM: Tying down the pallet!\n");
            }
        }

      
    
            
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
            BaseCommander A = new BaseCommander();
            AirTrafficControl B = new AirTrafficControl();
            Crew C = new Crew();
            LoadTeamChief D = new LoadTeamChief();
            Driver E = new Driver();
            Driver E2 = new Driver();
            RampController F = new RampController();
            Handler H = new Handler();

            Console.WriteLine("The beginning of the mission: The commander states his needs.\n");
            Thread.Sleep(2000);
            A.Brief();
            Thread.Sleep(2000);
            D.Salute();
            Thread.Sleep(1500);
            A.ReturnSalute();
            Thread.Sleep(2000);

            Console.WriteLine("The Team Cheif gets his crew\n");
            Thread.Sleep(2000);
            D.Brief();
            Thread.Sleep(2000);

            Console.WriteLine("The Load team prepares the load \n");
            H.BuildPallet();
            Thread.Sleep(2000);
            E.GetVehicleForklift();
            Thread.Sleep(2000);
            E.LoadForkLift();
            Thread.Sleep(2000);
            E2.GetVehicleKLoader();
            Thread.Sleep(2000);
            E.LoadKLoader();
            Thread.Sleep(2000);
            E2.DriveToFlightLine();
            Thread.Sleep(2000);

            Console.WriteLine("The Load team loadsv the pallet \n");
            Thread.Sleep(2000);
            F.ArriveAtAirCraft();
            D.ReceiveMessage();
            Thread.Sleep(2000);
            F.RequestOpenDoor();
            Thread.Sleep(2000);
            C.OpenAirCraftDoor();
            Thread.Sleep(2000);
            E2.ApproachAirCraft();
            Thread.Sleep(2000);
            F.StartLoad();
            Thread.Sleep(2000);
            D.ReceiveMessage();
            Thread.Sleep(2000);
            H.PushPallet();
            Thread.Sleep(2000);
            H.TieDownPallet();
            Thread.Sleep(2000);
            F.NotifyCrew();
            Thread.Sleep(2000);
            C.InspectLoad();
            Thread.Sleep(2000);
            C.ApproveLoad();
            Thread.Sleep(2000);
            F.EndLoad();
            Thread.Sleep(2000);
            D.ReceiveMessage();
            Thread.Sleep(2000);
            F.DismissLoadTeam();
            Thread.Sleep(2000);
            C.StartAirCraftEngines();
            Thread.Sleep(2000);

            Console.WriteLine("The AirCraft Departs.\n");
            C.RequestTakeOff();
            Thread.Sleep(2000);
            B.ApproveTakeoff();
            Thread.Sleep(2000);
            C.TakeOff();
            Thread.Sleep(2000);
            F.CallDeparture();
            Thread.Sleep(2000);
            D.ReceiveMessage();
            Thread.Sleep(2000);
            B.Brief();
            Thread.Sleep(2000);

            Console.WriteLine("==========================================MISSION COMPLETE===========================================");
       }
    }
}
