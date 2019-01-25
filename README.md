# ExcelToJson
A useful tool for converting MS Excel files(.xls or .xlsx) to Json type files


* EXCEL FILE FORMAT<br>
![](https://github.com/LizhuWeng/ExcelToJson/blob/master/Doc/sample_excel.JPG)
<br><br>
>> First row is used for descriptions of data structs.<br>
>> Second row is used for data property names (or IDs). <br>
>>> Tip: ID with bracket can be used just for description in Excel cells.<br>
>> All the following rows are datas<br>

<br><br>
* RESULT JSON<br>
```json
[{"Name":"idle","FadeTime":"0.4"},{"Name":"run","FadeTime":"0.3"},{"Name":"dance","FadeTime":"0.3"},{"Name":"attack","FadeTime":"0.5"}]
```

<br>
![](https://github.com/LizhuWeng/ExcelToJson/blob/master/Doc/test_result.JPG)


# NOTE
  For reading data from Microsoft Office Excel, you should check if Access database engine 2007 or newer has been installed in your PC.
