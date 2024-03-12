using System;
using static Program.KodePos;
using static Program.DoorMachine;
public class Program
{
    public class KodePos
    {
        public enum Kelurahan
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekajati,
            Kebonwaru,
            Maleer,
            Samoja
        }

        public static string getKodePos(Kelurahan nama)
        {
            string[] kodePos = {
        "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };
            return kodePos[(int)nama];
        }
    }

    public class DoorMachine
    {
        public enum DoorState { TERKUNCI, TERBUKA};
        public enum Trigger {KUNCI_PINTU, BUKA_PINTU};

        public class Transition
        {
            public DoorState StateAwal;
            public DoorState StateAkhir;
            public Trigger Trigger;

            public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }
        Transition[] transisi = 
        { 
            new Transition(DoorState.TERKUNCI, DoorState.TERBUKA, Trigger.BUKA_PINTU),
            new Transition(DoorState.TERBUKA, DoorState.TERKUNCI, Trigger.KUNCI_PINTU)
        };
        public DoorState currentState = DoorState.TERKUNCI;
        public DoorState GetNextState(DoorState stateAwal, Trigger trigger) 
        { 
            DoorState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
                {
                    stateAkhir = perubahan.StateAkhir;
                }
            }
            return stateAkhir;
        }
        public void ActiveTrigger(Trigger trigger)
        {
            currentState = GetNextState(currentState, trigger);
            if (currentState == DoorState.TERKUNCI)
            {
                Console.WriteLine($"State saat ini adalah {currentState} maka Pintu Terkunci");
            } else if (currentState == DoorState.TERBUKA)
            {
                Console.WriteLine($"State saat ini adalah {currentState} maka Pintu Tidak Terkunci");
            }
        }
    }


        public static void Main(String[] args)
        {
        Console.WriteLine("Kelurahan " + Kelurahan.Batununggal + " Memiliki Kode Pos " + getKodePos(Kelurahan.Batununggal));

        DoorMachine door = new DoorMachine();
        Console.WriteLine(door.currentState);

        door.ActiveTrigger(Trigger.KUNCI_PINTU);
        door.ActiveTrigger(Trigger.BUKA_PINTU);
    }
}