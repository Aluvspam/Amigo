﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public enum SupportShift// am zis ca e mai bine sa avem un enum, pt ca se presupune ca stiu ca exista 2 sift-uri si nu are rost sa complic situatia cu DateTime
    {
        NullShift,//this will be the initial stage of a engineers shift
        FirstShift,//repezinta prima parte a zilei, dintr-o zi de munca
        SecondShift//reprezinta a doua parte a zilei, dintr-o zi de munca
    }
}
