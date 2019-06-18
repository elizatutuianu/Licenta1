﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Models
{
    public class Dorm
    {
        [Key]
        private int id;
        private string dormName;
        private int dormComfort;
        private int dormNoRooms;
        private int dormBedsInRoom;
        private string dormGender;
        private bool isDormForRomanians;
        private List<Room> rooms = new List<Room>();
        string roomGender;

        [Required(ErrorMessage = ResourcesStrings.REQUIRED)]
        [MinLength(3)]
        public string DormName { get => dormName; set => dormName = value; }

        [Required(ErrorMessage = ResourcesStrings.REQUIRED)]
        public int DormComfort { get => dormComfort; set => dormComfort = value; }

        [Required(ErrorMessage = ResourcesStrings.REQUIRED)]
        public int DormNoRooms { get => dormNoRooms; set => dormNoRooms = value; }

        [Required(ErrorMessage = ResourcesStrings.REQUIRED)]
        public int DormBedsInRoom
        {
            get => dormBedsInRoom;
            set
            {
                dormBedsInRoom = value;
                foreach (Room room in this.Rooms)
                    room.BedsInRoom = DormBedsInRoom;
            }
        }

        [Required(ErrorMessage = ResourcesStrings.REQUIRED)]
        public string DormGender { get => dormGender; set => dormGender = value; } //F,M,Mixt

        [Required(ErrorMessage = ResourcesStrings.REQUIRED)]
        public bool IsDormForRomanians { get => isDormForRomanians; set => isDormForRomanians = value; }
        public List<Room> Rooms
        {
            get => rooms;
            set
            {
                //for (int i = 0; i < this.DormNoRooms; i++)
                //{
                //    if (this.DormGender == "F")
                //        roomGender = "F";
                //    else if (this.DormGender == "M")
                //        roomGender = "M";
                //    else
                //        roomGender = null;
                //    rooms.Add(new Room(i + 1, roomGender, null));
                //}
                rooms = value;
            }
        }
        public int Id { get => id; set => id = value; }
        public int DormBedsInRoom1 { get => dormBedsInRoom; set => dormBedsInRoom = value; }
        public string RoomGender { get => roomGender; set => roomGender = value; }
    }
}
