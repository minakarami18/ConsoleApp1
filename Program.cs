
using System;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Collections.Generic;
using Csharp;
using System.Security.Cryptography.X509Certificates;

namespace Csharp
{
    class Dormitory
    {
        public string nameD;
        public string address;
        public int capacity;
        public ResDormitory RD;
        public List<Block> blocks;
        private int count;
        public Dormitory(string nameD, string address, int capacity, ResDormitory RD)
        {
            this.nameD = nameD;
            this.address = address;
            this.capacity = capacity;
            this.RD = RD;
            blocks = new List<Block>();
            count = 0;
        }

        public bool isEmpty
        {
            get
            {
                if(count == 0) return false;
                else return true;
            }
        }
        public bool isFull
        {
            get
            {
                if(count >= 1000) return true;
                else return false;
            }
        }

        public void addDormitory(string _nameD, string _address, int _capacity, ResDormitory _RD)
        {   
            if(!isFull)
            {
                Dormitories[count] = new Dormitory(_nameD, _address, _capacity, _RD);
                count++;
            }
            

        }
        public void delDormitory(string _name)
        {
            if(!isEmpty)
            {
                for(int i = 0; i < count; i++)
                {
                    if(dormitories[i].nameD == _nameD)
                    {
                        dormitories.RemoveAt(count);
                    }
                }
            }
        }


    }
    class Room
    {
        public int roomNum;
        public int floor;
        public int capacity;
        public List<Equipment> Equ;
        public List<Student> students;
        public Block block;
        public Room(int roomNum, int floor, int capacity, Block block)
        {
            this.roomNum = roomNum;
            this.floor = floor;
            this.capacity = capacity;
            this.block = block;
            students = new List<Student>();
            Equ = new List<Equipment>();
        }

    }
    class Equipment
    {
        public string type;
        public int PartNum;
        public int propertyNum;
        public string Status;
        public Room room;
        public Student relStudent;
        public Equipment(string type, int PartNum, int propertyNum, string Status, Room room, Student relStudent)
        {
            this.type = type;
            this.PartNum = PartNum;
            this.propertyNum = propertyNum;
            this.Status = Status;
            this.room = room;
            this.relStudent = relStudent;
        }
    }
    class Block
    {
        public string blockName;
        public int floorsCount;
        public int roomsCount;
        public ResBlock resBlock;
        public List<Room> rooms;
        public Dormitory relDormitory;
        public Block(string blockName, int floorsCount, int roomsCount, ResBlock resBlock, Dormitory relDormitory)
        {
            this.blockName = blockName;
            this.floorsCount = floorsCount;
            this.roomsCount = roomsCount;
            this.resBlock = resBlock;
            rooms = new List<Room>();
            this.relDormitory = relDormitory;
        }
    }

    class Person
    {
        public string name;
        public int id;
        public string phoneNum;
        public string address;

        public Person(string name, int id, string phoneNum, string address) {
            this.name = name;
            this.id = id;
            this.phoneNum = phoneNum;
            this.address = address;
        }
        
    }

    class ResDormitory : Person
    {
        public string position;
        public Dormitory relDormitory;
        public ResDormitory(string name, int id, string phoneNum, string address, string position, Dormitory relDormitory) : base(name, id, phoneNum, address)
        {
            this.position = position;
            this.relDormitory = relDormitory;
        }
    }

    class ResBlock
    {
        public string position;
        public Block relBlock;
        public ResBlock(string position, Block relBlock)
        {
            this.position = position;
            this.relBlock = relBlock;
        }
    }

    class Student : Person
    {
        public int studentId;
        public Room room;
        public Block block;
        public Dormitory dormitory;
        public List<Equipment> personalEqu;
        public Student(string name, int id, string phoneNum, string address, int studentId, Room room, Block block, Dormitory dormitory) : base(name, id, phoneNum, address)
        {
            this.studentId = studentId;
            this.room = room;
            this.block = block;
            this.dormitory = dormitory;
            personalEqu = new List<Equipment>();
        }

    }

    class Program
    {
        static void Main()
        {
            List<Dormitory> dormitories = new List<Dormitory>(1000);

            Console.WriteLine("menu : <Dormitory management> <Block management> <People management> <Property management> <Reporting>");
            Console.WriteLine("please select one option");
            Console.WriteLine("mina");
        }
    }
}



