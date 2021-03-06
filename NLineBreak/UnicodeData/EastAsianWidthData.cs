// NLineBreak - a .NET implementation of the Line Breaking Algorithm (http://www.unicode.org/reports/tr14/).
// Copyright (C) 2009-2013 Maxim Rylov
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// ---
//
// Unicode Data Copyright:
// Copyright © 1998-2013 Unicode, Inc. All Rights Reserved. Distributed under the Terms of Use in http://www.unicode.org/copyright.html.


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace NLineBreak
{
	internal static class EastAsianWidthData
	{
		#region Default list of East Asian Width properties

		private static EastAsianWidthProperty[] properties = new EastAsianWidthProperty[]
		{
			new EastAsianWidthProperty(0x0000, 0x001F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0020, 0x007E, EastAsianWidthClass.Na),
			new EastAsianWidthProperty(0x007F, 0x00A0, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00A1, 0x00A1, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00A2, 0x00A3, EastAsianWidthClass.Na),
			new EastAsianWidthProperty(0x00A4, 0x00A4, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00A5, 0x00A6, EastAsianWidthClass.Na),
			new EastAsianWidthProperty(0x00A7, 0x00A8, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00A9, 0x00A9, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00AA, 0x00AA, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00AB, 0x00AB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00AC, 0x00AC, EastAsianWidthClass.Na),
			new EastAsianWidthProperty(0x00AD, 0x00AE, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00AF, 0x00AF, EastAsianWidthClass.Na),
			new EastAsianWidthProperty(0x00B0, 0x00B4, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00B5, 0x00B5, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00B6, 0x00BA, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00BB, 0x00BB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00BC, 0x00BF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00C0, 0x00C5, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00C6, 0x00C6, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00C7, 0x00CF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00D0, 0x00D0, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00D1, 0x00D6, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00D7, 0x00D8, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00D9, 0x00DD, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00DE, 0x00E1, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00E2, 0x00E5, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00E6, 0x00E6, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00E7, 0x00E7, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00E8, 0x00EA, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00EB, 0x00EB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00EC, 0x00ED, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00EE, 0x00EF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00F0, 0x00F0, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00F1, 0x00F1, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00F2, 0x00F3, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00F4, 0x00F6, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00F7, 0x00FA, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00FB, 0x00FB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00FC, 0x00FC, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00FD, 0x00FD, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x00FE, 0x00FE, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x00FF, 0x0100, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0101, 0x0101, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0102, 0x0110, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0111, 0x0111, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0112, 0x0112, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0113, 0x0113, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0114, 0x011A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x011B, 0x011B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x011C, 0x0125, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0126, 0x0127, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0128, 0x012A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x012B, 0x012B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x012C, 0x0130, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0131, 0x0133, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0134, 0x0137, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0138, 0x0138, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0139, 0x013E, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x013F, 0x0142, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0143, 0x0143, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0144, 0x0144, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0145, 0x0147, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0148, 0x014B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x014C, 0x014C, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x014D, 0x014D, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x014E, 0x0151, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0152, 0x0153, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0154, 0x0165, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0166, 0x0167, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0168, 0x016A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x016B, 0x016B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x016C, 0x01CD, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01CE, 0x01CE, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01CF, 0x01CF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01D0, 0x01D0, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01D1, 0x01D1, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01D2, 0x01D2, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01D3, 0x01D3, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01D4, 0x01D4, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01D5, 0x01D5, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01D6, 0x01D6, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01D7, 0x01D7, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01D8, 0x01D8, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01D9, 0x01D9, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01DA, 0x01DA, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01DB, 0x01DB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x01DC, 0x01DC, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x01DD, 0x0250, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0251, 0x0251, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0252, 0x0260, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0261, 0x0261, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0262, 0x02C3, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02C4, 0x02C4, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02C5, 0x02C6, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02C7, 0x02C7, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02C8, 0x02C8, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02C9, 0x02CB, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02CC, 0x02CC, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02CD, 0x02CD, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02CE, 0x02CF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02D0, 0x02D0, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02D1, 0x02D7, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02D8, 0x02DB, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02DC, 0x02DC, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02DD, 0x02DD, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02DE, 0x02DE, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x02DF, 0x02DF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x02E0, 0x02FF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0300, 0x036F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0370, 0x0390, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0391, 0x03A9, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x03AA, 0x03B0, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x03B1, 0x03C1, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x03C2, 0x03C2, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x03C3, 0x03C9, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x03CA, 0x0400, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0401, 0x0401, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0402, 0x040F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0410, 0x044F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0450, 0x0450, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x0451, 0x0451, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x0452, 0x10FF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x1100, 0x115F, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x1160, 0x200F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2010, 0x2010, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2011, 0x2012, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2013, 0x2016, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2017, 0x2017, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2018, 0x2019, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x201A, 0x201B, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x201C, 0x201D, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x201E, 0x201F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2020, 0x2022, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2023, 0x2023, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2024, 0x2027, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2028, 0x202F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2030, 0x2030, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2031, 0x2031, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2032, 0x2033, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2034, 0x2034, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2035, 0x2035, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2036, 0x203A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x203B, 0x203B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x203C, 0x203D, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x203E, 0x203E, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x203F, 0x2071, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2074, 0x2074, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2075, 0x207E, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x207F, 0x207F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2080, 0x2080, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2081, 0x2084, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2085, 0x20A8, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x20A9, 0x20A9, EastAsianWidthClass.H),
			new EastAsianWidthProperty(0x20AA, 0x20AB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x20AC, 0x20AC, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x20AD, 0x2102, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2103, 0x2103, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2104, 0x2104, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2105, 0x2105, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2106, 0x2108, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2109, 0x2109, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x210A, 0x2112, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2113, 0x2113, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2114, 0x2115, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2116, 0x2116, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2117, 0x2120, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2121, 0x2122, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2123, 0x2125, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2126, 0x2126, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2127, 0x212A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x212B, 0x212B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x212C, 0x2152, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2153, 0x2154, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2155, 0x215A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x215B, 0x215E, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x215F, 0x215F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2160, 0x216B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x216C, 0x216F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2170, 0x2179, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x217A, 0x2188, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2189, 0x2199, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x219A, 0x21B7, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x21B8, 0x21B9, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x21BA, 0x21D1, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x21D2, 0x21D2, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x21D3, 0x21D3, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x21D4, 0x21D4, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x21D5, 0x21E6, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x21E7, 0x21E7, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x21E8, 0x21FF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2200, 0x2200, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2201, 0x2201, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2202, 0x2203, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2204, 0x2206, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2207, 0x2208, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2209, 0x220A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x220B, 0x220B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x220C, 0x220E, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x220F, 0x220F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2210, 0x2210, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2211, 0x2211, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2212, 0x2214, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2215, 0x2215, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2216, 0x2219, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x221A, 0x221A, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x221B, 0x221C, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x221D, 0x2220, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2221, 0x2222, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2223, 0x2223, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2224, 0x2224, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2225, 0x2225, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2226, 0x2226, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2227, 0x222C, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x222D, 0x222D, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x222E, 0x222E, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x222F, 0x2233, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2234, 0x2237, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2238, 0x223B, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x223C, 0x223D, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x223E, 0x2247, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2248, 0x2248, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2249, 0x224B, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x224C, 0x224C, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x224D, 0x2251, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2252, 0x2252, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2253, 0x225F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2260, 0x2261, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2262, 0x2263, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2264, 0x2267, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2268, 0x2269, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x226A, 0x226B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x226C, 0x226D, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x226E, 0x226F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2270, 0x2281, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2282, 0x2283, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2284, 0x2285, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2286, 0x2287, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2288, 0x2294, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2295, 0x2295, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2296, 0x2298, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2299, 0x2299, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x229A, 0x22A4, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x22A5, 0x22A5, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x22A6, 0x22BE, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x22BF, 0x22BF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x22C0, 0x2311, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2312, 0x2312, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2313, 0x2328, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2329, 0x232A, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x232B, 0x244A, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2460, 0x24E9, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x24EA, 0x24EA, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x24EB, 0x254B, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x254C, 0x254F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2550, 0x2573, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2574, 0x257F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2580, 0x258F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2590, 0x2591, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2592, 0x2595, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2596, 0x259F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25A0, 0x25A1, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25A2, 0x25A2, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25A3, 0x25A9, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25AA, 0x25B1, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25B2, 0x25B3, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25B4, 0x25B5, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25B6, 0x25B7, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25B8, 0x25BB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25BC, 0x25BD, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25BE, 0x25BF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25C0, 0x25C1, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25C2, 0x25C5, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25C6, 0x25C8, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25C9, 0x25CA, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25CB, 0x25CB, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25CC, 0x25CD, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25CE, 0x25D1, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25D2, 0x25E1, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25E2, 0x25E5, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25E6, 0x25EE, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x25EF, 0x25EF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x25F0, 0x2604, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2605, 0x2606, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2607, 0x2608, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2609, 0x2609, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x260A, 0x260D, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x260E, 0x260F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2610, 0x2613, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2614, 0x2615, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2616, 0x261B, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x261C, 0x261C, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x261D, 0x261D, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x261E, 0x261E, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x261F, 0x263F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2640, 0x2640, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2641, 0x2641, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2642, 0x2642, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2643, 0x265F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2660, 0x2661, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2662, 0x2662, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2663, 0x2665, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2666, 0x2666, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2667, 0x266A, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x266B, 0x266B, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x266C, 0x266D, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x266E, 0x266E, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x266F, 0x266F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2670, 0x269D, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x269E, 0x269F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x26A0, 0x26BD, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x26BE, 0x26BF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x26C0, 0x26C3, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x26C4, 0x26CD, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x26CE, 0x26CE, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x26CF, 0x26E1, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x26E2, 0x26E2, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x26E3, 0x26E3, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x26E4, 0x26E7, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x26E8, 0x26FF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2701, 0x273C, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x273D, 0x273D, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x273E, 0x2756, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2757, 0x2757, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2758, 0x2775, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2776, 0x277F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2780, 0x27E5, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x27E6, 0x27ED, EastAsianWidthClass.Na),
			new EastAsianWidthProperty(0x27EE, 0x2984, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2985, 0x2986, EastAsianWidthClass.Na),
			new EastAsianWidthProperty(0x2987, 0x2B54, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2B55, 0x2B59, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x2C00, 0x2E3B, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x2E80, 0x2FFB, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x3000, 0x3000, EastAsianWidthClass.F),
			new EastAsianWidthProperty(0x3001, 0x303E, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x303F, 0x303F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x3041, 0x3247, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x3248, 0x324F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x3250, 0x33FF, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x3400, 0x4DB5, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x4DB6, 0x4DBF, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x4DC0, 0x4DFF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x4E00, 0x9FCC, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x9FCD, 0x9FFF, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xA000, 0xA4C6, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xA4D0, 0xA95F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xA960, 0xA97C, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xA980, 0xABF9, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xAC00, 0xD7A3, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xD7B0, 0xD7FB, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xD800, 0xDB7F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xDB80, 0xDBFF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xDC00, 0xDFFF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xE000, 0xF8FF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0xF900, 0xFA6D, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xFA6E, 0xFA6F, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xFA70, 0xFAD9, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xFADA, 0xFAFF, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xFB00, 0xFDFD, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xFE00, 0xFE0F, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0xFE10, 0xFE19, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xFE20, 0xFE26, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xFE30, 0xFE6B, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xFE70, 0xFEFF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xFF01, 0xFF60, EastAsianWidthClass.F),
			new EastAsianWidthProperty(0xFF61, 0xFFDC, EastAsianWidthClass.H),
			new EastAsianWidthProperty(0xFFE0, 0xFFE6, EastAsianWidthClass.F),
			new EastAsianWidthProperty(0xFFE8, 0xFFEE, EastAsianWidthClass.H),
			new EastAsianWidthProperty(0xFFF9, 0xFFFC, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xFFFD, 0xFFFD, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x10000, 0x16F9F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x1B000, 0x1B001, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x1D000, 0x1F0DF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x1F100, 0x1F12D, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x1F12E, 0x1F12E, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x1F130, 0x1F169, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x1F16A, 0x1F16B, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x1F170, 0x1F19A, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x1F1E6, 0x1F1FF, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x1F200, 0x1F251, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x1F300, 0x1F773, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0x20000, 0x2A6D6, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x2A6D7, 0x2A6FF, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x2A700, 0x2B734, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x2B735, 0x2B73F, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x2B740, 0x2B81D, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x2B81E, 0x2F7FF, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x2F800, 0x2FA1D, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x2FA1E, 0x2FFFD, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0x30000, 0x3FFFD, EastAsianWidthClass.W),
			new EastAsianWidthProperty(0xE0001, 0xE007F, EastAsianWidthClass.N),
			new EastAsianWidthProperty(0xE0100, 0xE01EF, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0xF0000, 0xFFFFD, EastAsianWidthClass.A),
			new EastAsianWidthProperty(0x100000, 0x10FFFD, EastAsianWidthClass.A),
		};

		#endregion

		public static EastAsianWidthProperty[] GetData()
		{
			return properties;
		}
	}
}
