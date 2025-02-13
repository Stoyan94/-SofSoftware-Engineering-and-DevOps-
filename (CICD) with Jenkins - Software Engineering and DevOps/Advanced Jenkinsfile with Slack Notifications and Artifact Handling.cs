Advanced Jenkinsfile with Slack Notifications and Artifact Handling
Here’s an advanced Jenkinsfile that includes:
✅ Slack notifications for different pipeline results
✅ Artifact archiving on success
✅ Debug logs collection on failure


pipeline {
    agent any

    environment {
        SLACK_CHANNEL = '#build-notifications'
        SLACK_WEBHOOK = 'https://hooks.slack.com/services/your-webhook-url'
    }

    stages {
        stage('Build') {
            steps {
                echo 'Building the application...'
                // Simulating build step
                sh 'mkdir -p build && echo "Build artifact" > build/artifact.txt'
            }
        }

        stage('Test') {
    steps {
        echo 'Running tests...'
                script {
            def randomFail = new Random().nextInt(10) < 3 // Simulate random failure (30% chance)
                    if (randomFail)
            {
                error("Simulated test failure")
                    }
        }
    }
}
    }

    post {
        always {
            echo 'Cleaning up temporary files...'
        }

        success {
            echo 'Build succeeded! Archiving artifacts...'
            archiveArtifacts artifacts: 'build/**', fingerprint: true

            script {
                def message = "*SUCCESS:* ✅ Build #${env.BUILD_NUMBER} passed!"
                sendSlackNotification(message)
            }
        }

        failure {
            echo 'Build failed! Collecting logs...'
            sh 'mkdir -p logs && echo "Error log for build ${env.BUILD_NUMBER}" > logs/error.log'
            archiveArtifacts artifacts: 'logs/**', allowEmptyArchive: true

            script {
                def message = "*FAILURE:* ❌ Build #${env.BUILD_NUMBER} failed! Check logs."
                sendSlackNotification(message)
            }
        }

        unstable {
            script {
                def message = "*UNSTABLE:* ⚠️ Build #${env.BUILD_NUMBER} is unstable! Tests might have failed."
                sendSlackNotification(message)
            }
        }

        changed {
            script {
                def message = "*STATUS CHANGED:* 🔄 Build #${env.BUILD_NUMBER} status changed from last build."
                sendSlackNotification(message)
            }
        }
    }
}

// Function to send Slack notification
def sendSlackNotification(String message)
{
    sh """
        curl -X POST -H 'Content-type: application/json' --data '{"text": "${message}"}' ${SLACK_WEBHOOK}
    """
}



Breakdown of Advanced Features

Slack Notifications
Uses a Slack webhook to send messages.
success, failure, unstable, and changed statuses trigger different messages.

Artifact Handling
If the pipeline succeeds, the build artifacts are archived (archiveArtifacts artifacts: 'build/**').
If the pipeline fails, logs are saved and archived (logs/error.log).

Debugging on Failure
Creates a logs/error.log file to collect error details.
Allows empty archives (allowEmptyArchive: true) to avoid failures in case no logs exist.
