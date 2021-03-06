﻿//BSD, 2014-2016, WinterDev
//----------------------------------------------------------------------------
// Anti-Grain Geometry - Version 2.4
//
// C# Port port by: Lars Brubaker
//                  larsbrubaker@gmail.com
// Copyright (C) 2007-2011
//
// Permission to copy, use, modify, sell and distribute this software 
// is granted provided this copyright notice appears in all copies. 
// This software is provided "as is" without express or implied
// warranty, and with no claim as to its suitability for any purpose.
//

//----------------------------------------------------------------------------

namespace PixelFarm.Agg
{
    //----------------------------
    public static class ScanlineRasToDestBitmapRendererExtension
    {
        public static void RenderSolidAllPaths(this ScanlineRasToDestBitmapRenderer sclineRasToBmp,
             IImageReaderWriter destImage,
              ScanlineRasterizer sclineRas,
              Scanline scline,
              VertexStore vxs,
              Drawing.Color[] colors,
              int[] path_id,
              int num_paths)
        {
            for (int i = 0; i < num_paths; ++i)
            {
                sclineRas.Reset();
                sclineRas.AddPath(new VertexStoreSnap(vxs, path_id[i]));
                sclineRasToBmp.RenderWithColor(destImage, sclineRas, scline, colors[i]);
            }
        }
    }
    //----------------------------
}