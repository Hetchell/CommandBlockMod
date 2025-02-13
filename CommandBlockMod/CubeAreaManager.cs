/*
MIT License

Copyright (c) 2017 Lixue_jiu

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using Engine;
using System;

namespace Game
{
  public static class CubeAreaManager
  {
    public static CubeArea SetArea(int x1, int y1, int z1, int x2, int y2, int z2) => new CubeArea()
    {
      PointMax = new Point3(Math.Max(x1, x2), Math.Max(y1, y2), Math.Max(z1, z2)),
      PointMin = new Point3(Math.Min(x1, x2), Math.Min(y1, y2), Math.Min(z1, z2)),
      LengthX = Math.Abs(x1 - x2) + 1,
      LengthY = Math.Abs(y1 - y2) + 1,
      LengthZ = Math.Abs(z1 - z2) + 1
    };
  }
}