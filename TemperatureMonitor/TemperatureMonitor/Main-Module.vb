Imports System.Math

Module Main_Module


    Public Function WorkMaterial(ByVal n As Double, ByVal qshear As Double, ByVal lambda As Double, ByVal k As Double, ByVal v As Double, _
                            ByVal a As Double, ByVal x As Double, ByVal z As Double, ByVal newl As Double, _
                           ByVal sa As Double, ByVal ra As Double, ByVal fs As Double, ByVal ps As Double, ByVal w As Double, ByVal shp As Double)
        Dim inter As Double
        Dim angle As Double
        angle = sa - ra
        Dim _
   nlookingthing, xvpart, lambdathing, _
   varl, qshearnumerator, qsheardenom, _
   qshearpart, kvlnum, kvldenom, kvlpart, xvnum, _
   xvdenom, vlsinnum, vlsindenom, vlsinpart, _
   firsthalf, secondhalf, sinmult, lsq, _
   ll, cosmult, numerator, denominator, firstpart, _
   secondpart, thirdpart, fourthpart, firstpartd, _
   secondpartd, thirdpartd, fourthpartd _
   As Double

        'newl = lfunction(qshear, sa)

        Dim zsq, xsq, solution As Double

        zsq = Pow(z, 2)
        xsq = Pow(x, 2)

        cosmult = Math.PI / 180
        cosmult = cosmult * angle
        cosmult = Cos(cosmult)

        'cosmult determined

        sinmult = Math.PI / 180
        sinmult = sinmult * angle
        sinmult = Sin(sinmult)

        'sinmult determined


        lsq = Pow(newl, 2)

        firstpart = sinmult * x * newl * 2
        secondpart = lsq * (Pow(sinmult, 2))
        thirdpart = 2 * z * newl * cosmult
        fourthpart = lsq * (Pow(cosmult, 2))


        firstpartd = -2 * x * sinmult
        secondpartd = 2 * newl * Pow(sinmult, 2)
        thirdpartd = 2 * z * cosmult
        fourthpartd = 2 * newl * Pow(cosmult, 2)


        'brakets solved

        numerator = xsq - firstpart + secondpart + zsq - thirdpart + fourthpart
        numerator = Pow(numerator, 1.5)
        numerator = numerator * 2

        'numerator solved



        denominator = firstpartd + secondpartd - thirdpartd + fourthpartd
        denominator = 3 * denominator

        ' denominator solved
        firsthalf = numerator / denominator




        '####################################################################
        'secondhalf begins solving
        numerator = xsq - firstpart + secondpart + zsq + thirdpart + fourthpart
        numerator = Pow(numerator, 1.5)
        numerator = numerator * 2


        'numerator solved
        denominator = firstpartd + secondpartd + thirdpartd + fourthpartd
        denominator = 3 * denominator

        ' denominator solved
        secondhalf = numerator / denominator

        'main equation solved
        '########################################################################


        firsthalf = firsthalf + secondhalf


        'inter = newl * w
        ''qshear = ((fsfunction(kabfunction(fs, ps, shp), qshear, w)) * vsfunction(v, ra, sa))
        'qshear = qshear / inter



        qsheardenom = 2 * Math.PI * lambda
        qshearpart = qshear / qsheardenom

        kvlnum = k * v * newl
        kvldenom = 2 * a
        kvlpart = kvlnum / kvldenom

        'calculate the ln part
        xvdenom = 2 * a
        xvnum = -1 * x * v
        xvpart = xvnum / xvdenom

        xvpart = Math.Exp(xvpart)

        Dim sin20 As Double
        sin20 = Math.Sin(Math.PI * angle / 180)


        vlsinnum = (Pow(newl, 2)) * v * sin20
        vlsindenom = 4 * a
        vlsinpart = vlsinnum / vlsindenom

        vlsinpart = Math.Exp(vlsinpart)


        'next is to multiply all parts together

        solution = n * qshearpart * kvlpart * xvpart * vlsinpart * firsthalf * 10



        Return solution


    End Function

    Public Function Chips(ByVal n As Double, ByVal qshear As Double, ByVal lambda As Double, ByVal k As Double, ByVal v As Double, _
                            ByVal a As Double, ByVal x As Double, ByVal z As Double, ByVal newl As Double, _
                           ByVal sa As Double, ByVal ra As Double, ByVal fs As Double, ByVal ps As Double, ByVal w As Double, ByVal shp As Double)
        Dim inter As Double
        Dim angle As Double
        angle = sa - ra
        Dim _
   nlookingthing, xvpart, lambdathing, _
   varl, qshearnumerator, qsheardenom, _
   qshearpart, kvlnum, kvldenom, kvlpart, xvnum, _
   xvdenom, vlsinnum, vlsindenom, vlsinpart, _
   firsthalf, secondhalf, sinmult, lsq, _
   ll, cosmult, numerator, denominator, firstpart, _
   secondpart, thirdpart, fourthpart, firstpartd, _
   secondpartd, thirdpartd, fourthpartd _
   As Double




        Dim zsq, xsq, solution As Double

        zsq = Pow(z, 2)
        xsq = Pow(x, 2)

        cosmult = Math.PI / 180
        cosmult = cosmult * angle
        cosmult = Cos(cosmult)

        'cosmult determined

        sinmult = Math.PI / 180
        sinmult = sinmult * angle
        sinmult = Sin(sinmult)

        v = v * sinmult / cosmult

        'sinmult determined


        lsq = Pow(newl, 2)

        firstpart = sinmult * x * newl * 2
        secondpart = lsq * (Pow(sinmult, 2))
        thirdpart = 2 * z * newl * cosmult
        fourthpart = lsq * (Pow(cosmult, 2))


        firstpartd = -2 * x * sinmult
        secondpartd = 2 * newl * Pow(sinmult, 2)
        thirdpartd = 2 * z * cosmult
        fourthpartd = 2 * newl * Pow(cosmult, 2)


        'brakets solved

        numerator = xsq - firstpart + secondpart + zsq - thirdpart + fourthpart
        numerator = Pow(numerator, 3)
        numerator = Sqrt(numerator)
        numerator = numerator * 2

        'numerator solved
        Dim new1, new1num, new1denom As Double
        Dim new2, new2num, new2denom As Double

        new1num = (xsq + zsq)
        new1num = Pow(new1num, 1.5)
        new1num = 2 * new1num

        new1denom = (-2 * x * sinmult) - (2 * z * cosmult)
        new1denom = 3 * new1denom

        new1 = new1num / new1denom





        denominator = firstpartd + secondpartd - thirdpartd + fourthpartd
        denominator = 3 * denominator

        ' denominator solved
        firsthalf = numerator / denominator

        firsthalf = firsthalf - new1


        '####################################################################
        'secondhalf begins solving
        numerator = xsq - firstpart + secondpart + zsq + thirdpart + fourthpart
        numerator = Pow(numerator, 3)
        numerator = Sqrt(numerator)
        numerator = numerator * 2


        'numerator solved
        denominator = firstpartd + secondpartd + thirdpartd + fourthpartd
        denominator = 3 * denominator


        new2num = (xsq + zsq)
        new2num = Pow(new2num, 1.5)
        new2num = 2 * new2num

        new2denom = (-2 * x * sinmult) + (2 * z * cosmult)
        new2denom = 3 * new2denom

        new2 = new2num / new2denom




        ' denominator solved
        secondhalf = numerator / denominator
        secondhalf = secondhalf - new2






        'main equation solved
        '########################################################################


        firsthalf = firsthalf + secondhalf


        'inter = newl * w
        'qshear = ((fsfunction(kabfunction(fs, ps, shp), qshear, w)) * vsfunction(v, ra, sa))
        'qshear = qshear / inter



        qsheardenom = 2 * Math.PI * lambda
        qshearpart = qshear / qsheardenom

        kvlnum = k * v * newl
        kvldenom = 2 * a
        kvlpart = kvlnum / kvldenom

        'calculate the ln part
        xvdenom = 2 * a
        xvnum = -1 * x * v
        xvpart = xvnum / xvdenom

        xvpart = Math.Exp(xvpart)


        Dim sin20 As Double
        sin20 = Math.Sin(Math.PI * angle / 180)


        vlsinnum = (Pow(newl, 2)) * v * sin20
        vlsindenom = 4 * a
        vlsinpart = vlsinnum / vlsindenom



        vlsinpart = Math.Exp(vlsinpart)


        'next is to multiply all parts together

        solution = n * qshearpart * kvlpart * xvpart * vlsinpart * firsthalf * 10



        Return solution


    End Function


    Public Function toolchip(ByVal n As Double, ByVal qshear As Double, ByVal lambda As Double, ByVal k As Double, ByVal v As Double, _
                             ByVal newl As Double, ByVal a As Double, ByVal x As Double, ByVal z As Double, _
                             ByVal hc As Double, ByVal fs As Double, ByVal ps As Double, ByVal shp As Double, ByVal ra As Double, ByVal sa As Double, ByVal w As Double)
        Dim inter As Double
        Dim angle As Double

        Dim _
   nlookingthing, xvpart, lambdathing, _
    varl, qshearnumerator, qsheardenom, _
   qshearpart, kvlnum, kvldenom, kvlpart, xvnum, _
   xvdenom, vlsinnum, vlsindenom, vlsinpart, _
   firsthalf, secondhalf, sinmult, lsq, _
   ll, cosmult, numerator, denominator, firstpart, _
   secondpart, thirdpart, fourthpart _
   As Double

        Dim xsq, zsq, xl, denomenator, tx, tl, hcsq, solution As Double

        xsq = Pow(x, 2)
        zsq = Pow(z, 2)
        lsq = Pow(newl, 2)
        hcsq = Pow(hc, 2)
        xl = 2 * x * newl

        numerator = xsq - xl + lsq + zsq

        numerator = Pow(numerator, 1.5)

        numerator = numerator * 2
        '''''''''#
        tl = 2 * newl
        tx = 2 * x

        denomenator = tx + tl
        denomenator = 3 * denomenator


        Dim new1, new1num, new1denom As Double

        new1num = (xsq + zsq)
        new1num = Pow(new1num, 1.5)

        new1denom = -3 * x

        new1 = new1num / new1denom

        firstpart = numerator / denomenator
        firstpart = firstpart - new1

        numerator = (xsq - (tl * x) + lsq + (4 * hcsq) + (4 * z * hc) + (zsq))
        numerator = Pow(numerator, 1.5)
        numerator = 2 * numerator


        Dim new2, new2num, new2denom As Double

        new2num = xsq + (4 * hcsq) + (4 * z * hc) + zsq
        new2num = Pow(new2num, 1.5)

        new2denom = -3 * x
        new2 = new2num / new2denom




        secondpart = numerator / denomenator

        secondpart = secondpart - new2

        firsthalf = firstpart + secondpart

        qsheardenom = PI * lambda




        'inter = newl * w
        'qshear = ((fsfunction(kabfunction(fs, ps, shp), qshear, w)) * vsfunction(v, ra, sa))
        'qshear = qshear / inter




        qshear = qshear / qsheardenom

        'kvldenom = 2 * a
        'kvlnum = k * newl * v

        'kvlpart = kvlnum / kvldenom

        xvnum = -1 * x * v
        xvdenom = 2 * a
        xvpart = xvnum / xvdenom


        xvpart = Math.Exp(xvpart)


        solution = n * qshear * k * xvpart * firsthalf


        Return solution


    End Function

    Public Function toolanalysis(ByVal tan As Double, ByVal tax As Double, ByVal taxi As Double, _
                                 ByVal tay As Double, ByVal taw As Double, ByVal taz As Double, _
                                 ByVal taLfull As Double, ByVal talambda As Double, ByVal taqshear As Double, _
                                 ByVal sa As Double, ByVal ra As Double, ByVal shp As Double, ByVal fs As Double, ByVal w As Double, ByVal ps As Double, ByVal v As Double)
        Dim solution, xsq As Double

        Dim thirdpartnum, thirdpartdenom As Double
        Dim secondpartdenom, secondpartnum As Double
        Dim fifthpartnum, fifthpartdenom As Double
        Dim qshearpart As Double
        Dim sixthnum, sixthdenom As Double
        Dim eightpartnum, eightpartdenom As Double
        Dim ninthpartnum, ninthparthdenom As Double
        Dim firstpart, secondpart, thirdpart, fourthpart, fifthpart, sixthpart, seventhpart, eigthpart, ninthpart, x, y, z, l, lsq, ysq, yw, wsq, zsq, zy As Double
        Dim first, second, third As Double
        x = tax
        l = taxi
        w = taw
        y = tay
        z = taz

        yw = y * w

        qshearpart = 2 * talambda * PI
        taqshear = taqshear / qshearpart


        xsq = Math.Pow(x, 2)
        lsq = Math.Pow(l, 2)
        wsq = Math.Pow(w, 2)
        ysq = Math.Pow(y, 2)
        zsq = Math.Pow(z, 2)

        firstpart = x - l
        firstpart = -3 * firstpart

        firstpart = 2 / firstpart




        secondpartnum = xsq - (2 * x * l) + lsq + ysq - (y * w) + (0.25 * wsq) + zsq
        secondpartnum = Pow(secondpartnum, 1.5)
        secondpartdenom = (-2 * y) + w

        secondpart = secondpartnum / secondpartdenom



        thirdpartnum = xsq - (2 * x * l) + lsq + ysq + zsq
        thirdpartnum = Pow(thirdpartnum, 1.5)
        thirdpartdenom = -2 * y


        fourthpart = 3 * (x - l)
        fourthpart = 2 / fourthpart

        fifthpartnum = xsq - (2 * x * l) + lsq + ysq - (y * w) + (0.25 * wsq) + zsq
        fifthpartnum = Math.Pow(fifthpartnum, 1.5)

        fifthpartdenom = (-2 * y) + w
        fifthpart = fifthpartnum / fifthpartdenom




        sixthnum = xsq - (2 * x * l) + lsq + ysq + zsq
        sixthnum = Pow(sixthnum, 1.5)
        sixthdenom = -2 * y

        sixthpart = sixthnum / sixthdenom

        seventhpart = ((2 * x) - (2 * l))
        seventhpart = 3 * seventhpart
        seventhpart = 2 / seventhpart



        eightpartnum = (4 * xsq) - (8 * x * l) + (4 * lsq) + ysq - (y * w) + (0.25 * wsq) + zsq
        eightpartnum = Pow(eightpartnum, 1.5)

        eightpartdenom = (-2 * y) + w
        eigthpart = eightpartnum / eightpartdenom



        ninthpartnum = ((4 * xsq) - (8 * x * l) + (4 * lsq) + ysq + zsq)
        ninthpartnum = Pow(ninthpartnum, 1.5)
        ninthparthdenom = -2 * y
        ninthpart = ninthpartnum / ninthparthdenom

        first = secondpart - thirdpart
        second = fifthpart - sixthpart
        third = eigthpart - ninthpart

        solution = (firstpart * first) + (fourthpart * second) - (seventhpart * third)

        solution = tan * taqshear * solution * 0.1

        Return solution
    End Function

    Public Function qshearFunction(ByVal fs As Double, ByVal vs As Double, ByVal l As Double, ByVal w As Double)
        Dim qshear As Double

        qshear = fs * vs / l
        qshear = qshear / w

        Return qshear

    End Function

    Public Function vsfunction(ByVal v As Double, ByVal alpha As Double, ByVal phi As Double)
        Dim vs As Double
        phi = phi - alpha

        phi = PI * phi / 180
        alpha = alpha * PI / 180

        phi = Cos(phi)
        alpha = Cos(alpha)

        vs = v * alpha / phi

        Return vs
    End Function


    Public Function vcfunction(ByVal v As Double, ByVal theta As Double, ByVal phi As Double)
        Dim vc As Double
        phi = phi - theta

        phi = PI * phi / 180
        theta = theta * PI / 180

        phi = Cos(phi)
        theta = Cos(theta)

        vc = v * theta / phi

        Return vc
    End Function

    Public Function fsfunction(ByVal kab As Double, ByVal tu As Double, ByVal w As Double)
        Dim fs As Double
        fs = kab * tu * w
        Return fs

    End Function

    Public Function kabfunction(ByVal fs As Double, ByVal ps As Double, ByVal n As Double)
        Dim kab As Double
        ps = Pow(ps, n)
        kab = Sqrt(3)

        kab = fs * ps / kab

        Return kab
    End Function

    Public Function lfunction(ByVal tu As Double, ByVal phi As Double)
        Dim l As Double

        phi = PI * phi / 180
        phi = Sin(phi)

        l = tu / phi
        Return l
    End Function

    Public Function tcfunction(ByVal tu As Double, ByVal sa As Double, ByVal ra As Double)
        Dim tc As Double

        sa = sa - ra
        sa = PI * sa / 180
        sa = Cos(sa)

        ra = sa * PI / 180
        ra = Sin(ra)

        tc = tu * sa / ra

        Return tc
    End Function
End Module
