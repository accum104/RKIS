using System;

namespace Rectangles;

public static class RectanglesTask
{
    // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
    public static bool AreIntersected(Rectangle r1, Rectangle r2)
    {
        // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
        return true;
        public static class RectanglesTask {
    public static bool AreIntersected(Rectangle r1, Rectangle r2) {
        bool horizontalOverlap = r1.Left <= r2.Right && r1.Right >= r2.Left;
        bool verticalOverlap = r1.Top <= r2.Bottom && r1.Bottom >= r2.Top;

        return horizontalOverlap && verticalOverlap;
    }

    // Площадь пересечения прямоугольников
    public static int IntersectionSquare(Rectangle r1, Rectangle r2)
    {
        return 0;
    public static int IntersectionSquare(Rectangle r1, Rectangle r2) {
        if (!AreIntersected(r1, r2))
            return 0;

        int intersectLeft = Math.Max(r1.Left, r2.Left);
        int intersectRight = Math.Min(r1.Right, r2.Right);

        int intersectTop = Math.Max(r1.Top, r2.Top);
        int intersectBottom = Math.Min(r1.Bottom, r2.Bottom);

        int intersectWidth = intersectRight - intersectLeft;
        int intersectHeight = intersectBottom - intersectTop;

        // Площадь пересечения
        return intersectWidth * intersectHeight;
    }

    // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
    // Иначе вернуть -1
    // Если прямоугольники совпадают, можно вернуть номер любого из них.
    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
    {
    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2) {
        bool r1InsideR2 = r1.Left >= r2.Left && r1.Right <= r2.Right &&
            r1.Top >= r2.Top && r1.Bottom <= r2.Bottom;

        bool r2InsideR1 = r2.Left >= r1.Left && r2.Right <= r1.Right &&
            r2.Top >= r1.Top && r2.Bottom <= r1.Bottom;

        if (r1InsideR2)
            return 0;
        if (r2InsideR1)
            return 1;
