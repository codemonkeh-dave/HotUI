﻿using System;
using HotUI.Graphics;
using HotUI.Skia;

namespace HotUI.Samples.Skia
{
    public class SkiaSample6 : View
    {
        private static readonly string PuzzlePiece = "M19.99792 22.13909 C19.99792 22.13909 47.86481 28.87755 49.04228 23.53727 C50.19575 18.30595 44.05524 17.74318 43.54738 11.65272 C43.0568 5.768704 47.91793 -0.09640692 56.49963 0.001201655 C65.03629 0.09829985 69.88357 5.380321 70.23681 11.26433 C70.70629 19.08429 64.00743 19.07113 66.15493 23.53727 C68.47058 28.35323 94.21521 22.23512 97.55423 26.25595 C101.2632 30.72237 100.5764 43.05355 96.69075 49.17059 C92.80509 55.28766 89.80248 46.60727 83.97403 48.00547 C78.14549 49.40363 78.51836 53.65646 78.87164 59.42395 C79.22488 65.19144 79.95097 68.25968 85.77946 69.13351 C91.60799 70.00739 94.49277 58.8802 96.69075 64.08453 C98.88867 69.28887 99.12417 90.30046 94.5713 95.77667 C90.39147 100.8041 65.07446 101.7156 63.95695 96.47578 C62.68137 90.49467 69.02008 92.63074 68.66684 87.38759 C68.3136 82.14436 62.0141 79.87233 55.47915 78.99846 C48.94418 78.12459 44.82301 78.64893 42.52691 83.8921 C40.23085 89.13531 48.45356 91.38793 46.68734 96.47578 C44.82262 101.8474 15.44503 96.47578 15.44503 96.47578 C15.44503 96.47578 22.30525 68.48328 15.91602 64.86131 C10.12676 61.57945 9.714652 69.26945 4.062778 66.64789 C-1.5891 64.02629 -0.07800946 57.98692 1.15834 52.04465 C2.394689 46.10238 5.970265 42.56891 10.18563 42.87878 C13.61994 43.13125 20.97916 53.19039 22.74536 49.17059 C24.51158 45.15082 19.99792 22.13909 19.99792 22.13909 Z ";

        private static readonly LinearGradient LinearGradient = new LinearGradient(
            new [] {Color.Salmon, Color.CornflowerBlue}, 
            new PointF(0,0), 
            new PointF(1,0));
        
        [Body]
        View body() => new VStack
        {
            new DrawableControl(
                new SkiaShapeView(
                    new Circle()
                        .Fill(LinearGradient)
                        .Style(DrawingStyle.Fill)))
                .Frame(100,60),

            new DrawableControl(
                new SkiaShapeView(
                    new Rectangle()
                        .Fill(LinearGradient)
                        .Style(DrawingStyle.Fill)))
                .Frame(100,60),

            new DrawableControl(
                new SkiaShapeView(
                    new RoundedRectangle(6)
                        .Fill(LinearGradient)
                        .Style(DrawingStyle.Fill)))
                .Frame(100,60),

            new DrawableControl(new SkiaShapeView(
                new Capsule()
                    .Fill(LinearGradient)
                    .Style(DrawingStyle.Fill)))
                .Frame(100,30),

            new DrawableControl(
                new SkiaShapeView(
                    new Ellipse()
                        .Fill(LinearGradient)
                        .Style(DrawingStyle.Fill)))
                .Frame(100,60),

            new DrawableControl(
                new SkiaShapeView(
                    new Path(PuzzlePiece)
                        .Fill(LinearGradient)
                        .Style(DrawingStyle.Fill)))
                .Frame(60,60)
        };
    }
}
