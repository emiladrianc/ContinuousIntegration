FROM jenkins:2.46.2

USER root

# copy the plugins file
COPY plugins.txt /usr/share/jenkins/plugins.txt

# drop back to jenkins user
USER jenkins

# install plugins
RUN /usr/local/bin/plugins.sh 			/usr/share/jenkins/plugins.txt

# disable initial setup wizard
ENV JAVA_OPTS "-Djenkins.install.runSetupWizard=false"

USER root

# install maven
RUN apt-get update && apt-get install -y maven
#RUN apt-get install dotnet-dev-1.0.0-preview2-003131

USER jenkins