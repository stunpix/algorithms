/***********************************************************************
This code is generated by the AlgoPascal translator

This code is distributed under the ALGLIB license
    (see http://www.alglib.net/copyrules.php for details)
***********************************************************************/
/*
This routines must be defined by the programmer:
static void setpixel(int x,
    int y,
    double alpha)
*/


/*************************************************************************
<<<<<<< HEAD
Рисование круга с использованием метода Ву для
антиалиасинга.
=======
��������� ����� � �������������� ������ �� ���
�������������.
>>>>>>> 58e3d87... Added Wu's antialiasing algorithms for circle, ellipsis, line
*************************************************************************/
public static void drawwucircle(int cx,
    int cy,
    int r)
{
    int x = 0;
    int y = 0;
    double t = 0;
    double d = 0;
    int j = 0;
    int kx = 0;
    int ky = 0;
    int lastx = 0;


    x = r;
    lastx = r;
    y = 0;
    t = 0;
    for(j=0; j<=3; j++)
    {
        kx = j%2*2-1;
        ky = j/2%2*2-1;
        setpixel(kx*x+cx, ky*y+cy, 1);
        setpixel(kx*y+cx, ky*x+cy, 1);
    }
    while( x>y )
    {
        y = y+1;
        d = (int)Math.Ceiling(Math.Sqrt(r*r-y*y))-Math.Sqrt(r*r-y*y);
        if( d<t )
        {
            x = x-1;
        }
        if( x<y )
        {
            break;
        }
        if( x==y & lastx==x )
        {
            break;
        }
        for(j=0; j<=3; j++)
        {
            kx = j%2*2-1;
            ky = j/2%2*2-1;
            setpixel(kx*x+cx, ky*y+cy, 1-d);
            setpixel(kx*y+cx, ky*x+cy, 1-d);
            if( x-1>=y )
            {
                setpixel(kx*(x-1)+cx, ky*y+cy, d);
                setpixel(kx*y+cx, ky*(x-1)+cy, d);
            }
        }
        t = d;
        lastx = x;
    }
}
