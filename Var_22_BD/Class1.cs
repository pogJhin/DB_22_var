using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_22_BD
{
    class Class1
    {
        public int i = 0; //счётчик 

        public double[] Zv = new double[20]; //эквивалентное число зубьев
        public string[] x = new string[20]; //коэффициент смещения
        public double[] Yf = new double[20]; //коэффициент, учитывающий форму зуба зависимо от зубъев
        public double[] YF = new double[20]; //коэффициент, учитывающий форму зуба
        public double[] xt1 = new double[20]; //коэффициент изменения толщины зуба 
        public double[] u = new double[20]; //передаточное число
        public double[] Bm = new double[20]; //средний угл наклона линии зуба
        public double[] Yb = new double[20]; //коэффициент, учитывающий наклон зуба
        public string[] NodeTipe = new string[20]; //тип зубьев передачи
        public double[] v = new double[20]; //скорость передачи
        public double[] N = new double[20]; //Мощность
        public double[] Ft = new double[20]; //Исходная расчётная сила
        public double[] z1 = new double[20]; //число зубьев шестерни
        public double[] ea = new double[20]; //коэффициент торцового перекрытия
        public double[] Kfa = new double[20]; //Коэффициент, учитывающий распределение нагрузки между зубьями
        public double[] g0 = new double[20]; //Коэффициент g0
        public string[] m = new string[20]; //Коэффициент m
        public double[] sigmaf = new double[20]; //Коэффициент, учитывающий влияние вида зубчатой передачи
        public double[] b = new double[20]; //ширина зубчатого венца
        public double[] wft = new double[20]; //удельная расчетная окружная сила
        public double[] Kfb = new double[20]; //коэффициент, учитывающий распределение нагрузки по ширине венца конического колеса
        public double[] Re = new double[20]; //внешнее конусное расстояние
        public double[] wfv = new double[20]; //удельная окружная динамическая сила
        public double[] Kfv = new double[20]; //Коэффициент, учитывающий динамическую нагрузку при расчете на изгиб зуба
        public double[] T1 = new double[20]; //крутящий момент
        public double[] dw = new double[20];//Средний делительный диаметр
        public double[] Mtm = new double[20]; //средний окружной модуль
        public double[] Mnm = new double[20]; //Минимальный нормальный допустимый модуль
        public double[] KF = new double[20]; //Коэффициент нагрузки
        public double[] Kfl = new double[20]; //Коэффициент долговечности
        public double[] sigma_fp = new double[20];//Коэффициент допускаемого напряжения при рассчете навыносливость зубьев по изгибу
        public double[] sigmafp = new double[20];//коэффициент допускаемого напряжения
        /*public double[] = new double[20];*/
    }
}
