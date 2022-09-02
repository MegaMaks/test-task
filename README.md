# test task


Клонируем репозиторий
```
git clone https://github.com/MegaMaks/test-task.git
```
Для сборки приложения понадобиться dot net core 6 https://docs.microsoft.com/ru-ru/dotnet/core/install/linux-ubuntu
```
cd test-task/
dotnet publish --runtime=linux-x64
```
Собираем docker образ
```
docker build . -t helloworld
```
Запускаем docker-compose
```
cd deployment/
docker-compose up
```

# информация по сервисам
application
```
http://ip-address:5000/ - основа основ
http://ip-address:5000/health - health check импровизированная проверка сервиса и коннекта к бд периодически меняет статус(с 200 на 503)
по формуле DateTime.Now.Millisecond % 2 == 0 
отдает в формате json
http://ip-address:5000/metrics - отдает метрики
```
prometheus
```
http://ip-address:9090/
```
grafana
```
http://ip-address:3000/ 
credentials admin:admin меняются при первом входе
dashboadrds:
metrics for app - визуализация метрик с dot net приложения, чтобы были данные для отображения нужно походить по страничкам / /health 
Node Exporter for Prometheus Dashboard - основные метрики с node exportera
```
