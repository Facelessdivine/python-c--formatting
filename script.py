def formater(data):
    ban = True
    flag = 0
    variable = ''
    for i in data:
        str(i)
        nclase = i.find('public class ')
        if nclase > 0:
            clase.append(i[nclase+13:])
        start = 0
        cont = 0
        end = 0
        mid = 0
        vart = ''
        for j in dataTypes:
            str(j)
            cont+=1
            start = i.find(j) 
            mid = i[start:].find(' ') 
            vart = i[start:]
            end = vart.find(' ') 
            vart = vart[end:]
            start = vart.find('{') 
            if start > 0 :
                ind = dataTypes.index(j)
                vart = vart[:start]+ "= " + str(valores[ind])+","+"\n"
                variable = i[start:end]
                lista.append(vart)
                cont = 0
                
lista  = []
dataTypes = ["bool", "DateTime", "long", "int", "string", "double", "float", " char", "byte[]", "short", "decimal"]
valores = ["true", "\"2018-09-18\"", 1, 1, "\"string\"", 1.0, 1.5, "\"c\"", "byte[]", 1, 1.0]
clase = []
e=open('entities/Bsanalisis.cs',encoding='utf-8', mode='r')
formater(e)
e.close()
c = open('config/BsanalisisConfiguration.cs' ,encoding='utf-8', mode='r')
lines = c.readlines()
c.close()
t = len(lines)
del lines[t-3:t]
c = open('config/BsanalisisConfiguration.cs' ,encoding='utf-8', mode='w+')
for line in lines:
    c.write(line)

c.close()
c = open('config/BsanalisisConfiguration.cs' ,encoding='utf-8', mode='a')
c.write("entity.HasData(\n")
c.write("new " + clase[0] + "\n")
c.write("{\n")
for i in lista: 
    c.write(str(i))
c.write("});\n")
c.write("}\n}\n}\n")
c.close()
lista.clear()   