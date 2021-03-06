namespace Application
{
    class Force_HTML
    {
        public string html = @"<!DOCTYPE html>

<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
    <meta charset=""utf-8"" />
    <title></title>
    <script type=""text/javascript""
  src=""https://cdn.mathjax.org/mathjax/latest/MathJax.js?config=TeX-AMS-MML_HTMLorMML"">
</script>
</head>
<body>
    <h1 style=""font-family: Bahnschrift; text-align: center; font-weight: bold"">Лабароторная работа</h1>
    <h2 style=""font-family: Bahnschrift; text-align: center; font-weight: bold"">{{labname}}</h2>
    <div style=""overflow: hidden;"">
        <div style=""font-family: Bahnschrift; width: 100%; font-size: 25px;"">
            <div style=""float: left; width: 328px; height: 306px; margin-right: 180px;"">Цель работы: {{aim}}</div>
            <div style=""float: left; width: 328px; height: 306px; margin-right: 180px; "">Оборудование: {{equipment}}</div>
            <div style=""float: left; width: 328px; height: 306px; "">Работу выполнил: {{firstname}} {{lastname}} 
             {{group}}</div>
        </div>
    </div>
    <div style=""font-family: Bahnschrift; width: 100%; margin-top:140px; font-size: 45px;"">
        Теоритическое обоснование
        <table style=""border: 3px solid #000000; width:100%; height: 900px;"">
        
            <tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
<div style=""font-family: Bahnschrift; width: 50%; margin-top:160px;  font-size: 45px;"">
    Результаты измерений
    <table style=""margin-top: 10px; font-size: 25px; border: 3px solid #000000; width: 200%; height: 300px; border-collapse: collapse;"">
        <tr>
            <td style=""padding: 3px; border: 1px solid black;"">Вид поверхности</td>
            <td style=""padding: 3px; border: 1px solid black;"">Число грузов</td>
            <td style=""padding: 3px; border: 1px solid black;"">Сила нормальной реакции опоры N, Н</td>
            <td style=""padding: 3px; border: 1px solid black;"">Сила трения F, H</td>
        </tr>
        {% for values in dem %}
            <tr>
                <td style=""padding: 3px; border: 1px solid black;"">{{values.Type_road}}</td>
                <td style=""padding: 3px; border: 1px solid black;"">{{values.Number}}</td>
                <td style=""padding: 3px; border: 1px solid black;"">{{values.Normal_reaction}}</td>
                <td style=""padding: 3px; border: 1px solid black;"">{{values.Force}}</td>
            </tr>
        {% endfor %}
    </table>
</div>  

    <img
    src=""{{graph}}""
    alt=""triangle with all three sides equal"" style=""height: 600px; width: 1000px"" />


<div style=""margin-top:50px; font-family: Bahnschrift; font-size: 45px;"">
    Расчет погрешностей измерений
    <img
    src=""{{formula}}""
    alt="""" style=""height: 100%; width: 100%"" />
</div>

<div style=""margin-top:50px; font-family: Bahnschrift; font-size: 45px;"">
    Эксперимент №2
    <p>l = {{length}}\(\pm\){{len_pogr}}</p>
    <p>h = {{height}}\(\pm\){{h_pogr}}</p>
    
   
    Расчет погрешностей измерений
    <img
    src=""{{formula_tan}}""
    alt="""" style=""height: 100%; width: 100%"" />
</div>
<div style=""margin-top:50px; font-family: Bahnschrift; font-size: 45px;"">
    Вывод
    <p style=""font-size: 25px;  text-align: left;"">
        {{final}}
    </p>
</div>
<div style=""font-family: Bahnschrift; width: 100%; margin-top:240px; font-size: 45px;"">
        Заметки
        <table style=""border: 3px solid #000000; width:100%; height: 900px;"">
        
            <tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr><tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div> 
</body>
</html>";
    }
}
