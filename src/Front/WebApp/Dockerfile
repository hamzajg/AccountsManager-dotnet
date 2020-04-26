# Set the base image
FROM node:lts-alpine3.9
# Define working directory
WORKDIR /var/www/app

# Install node_modules with yarn
ADD src/Front/WebApp/ /tmp/

RUN cd /tmp/Views && yarn
RUN mkdir -p /var/www/app && cd /var/www/app && ln -s /tmp/Views/node_modules
# Copy app
COPY src/Front/WebApp/Views /var/www/app
# Expose port
EXPOSE 3000
# Run app
RUN yarn build
# RUN cp -r /var/www/app/dist /var/www/app/src
ENTRYPOINT ["yarn","start"]
