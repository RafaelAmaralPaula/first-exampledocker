# Alguns comandos 
 ### Comando para gerar imagem
   ~~~Docker
   docker build --no-cache -f .\Dockerfile -t image_apitest ..
   ~~~
       
 ### Comando para gerar container

  ~~~Docker
  docker run --name container_apidockertest -p 8000:80 image_apitest .. 
  ~~~
