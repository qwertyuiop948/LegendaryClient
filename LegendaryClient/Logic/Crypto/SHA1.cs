﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LegendaryClient.Logic.Crypto
{
    public class Sha1 : Crypto
    {
        public override string Encode(byte[] data)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hashData = sha1.ComputeHash(data);
            string returnvalue = BitConverter.ToString(hashData).Replace("-","").ToLower();
            return returnvalue;
        }
    }
}
