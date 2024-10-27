pipeline {

    agent {
        label 'dotnet-build'
    }

    environment {
        DOTNET_CLI_TELEMETRY_OPTOUT = 'true'
    }

    stages {
        stage('Check-out Repo') {
            steps {
                script {
                    currentBuild.displayName = "Team:${env.BRANCH_NAME} - #${BUILD_NUMBER}"
                }
            }
        }

        stage('Build All') {
            steps {
                powershell 'dotnet build AxionBioSoftwareConference.sln --configuration Debug'
            }
        }

        stage('Test All') {
            steps {
                powershell 'dotnet test AxionBioSoftwareConference.sln --configuration Debug --logger:"junit;LogFilePath=test-nunit.xml"'
            }
        }
    }

    post {
        always {
            junit testResults: 'Tests/test-nunit.xml'
        }
        cleanup { // Clean after build
            cleanWs(cleanWhenNotBuilt: false,
                    deleteDirs: true,
                    disableDeferredWipeout: true,
                    notFailBuild: true,
                    patterns: [])
        }
    }
}
