﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    internal static class Segments
    {
        public static void UpdateSegments(this Indicator sevenSegmentIndicator, BoxView topSegment, BoxView leftTopSegment,
            BoxView rightTopSegment, BoxView middleSegment, BoxView leftBottomSegment, BoxView rightBottomSegment, BoxView bottomSegment)
        {
            topSegment.IsVisible = sevenSegmentIndicator.TopSegment;
            leftTopSegment.IsVisible = sevenSegmentIndicator.LeftTopSegment;
            rightTopSegment.IsVisible = sevenSegmentIndicator.RightTopSegment;
            middleSegment.IsVisible = sevenSegmentIndicator.MiddleSegment;
            leftBottomSegment.IsVisible = sevenSegmentIndicator.LeftBottomSegment;
            rightBottomSegment.IsVisible = sevenSegmentIndicator.RightBottomSegment;
            bottomSegment.IsVisible = sevenSegmentIndicator.BottomSegment;
        }
    }
}
