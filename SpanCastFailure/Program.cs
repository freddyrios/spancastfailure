﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

var bytes = Convert.FromHexString("0A0000000000000000");
var vectorBytes = bytes.AsSpan()[1..];
var vector = MemoryMarshal.Cast<byte, double>(vectorBytes);
foreach (var value in vector)
    Console.Write(value);

Console.WriteLine();
