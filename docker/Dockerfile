FROM node

COPY ./app /

WORKDIR /


RUN apt-get update && \
    apt-get upgrade -y && \
    apt-get install -y git
        
RUN npm install

ENTRYPOINT ["node", "app.js"]