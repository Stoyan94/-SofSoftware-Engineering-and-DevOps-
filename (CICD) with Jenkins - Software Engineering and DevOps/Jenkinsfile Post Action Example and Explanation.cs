Jenkinsfile Post Action Example and Explanation
In a Jenkinsfile, the post section is used to define actions that should be executed after the pipeline stage or the entire pipeline completes. 
The post block allows you to specify different actions depending on the pipeline's outcome, such as always, success, failure, and unstable.


pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building the application...'
            }
        }

        stage('Test') {
    steps {
        echo 'Running tests...'
                // Simulating a failure
                script {
            if (env.BUILD_NUMBER.toInteger() % 2 == 0)
            {
                error("Simulated test failure")
                    }
        }
    }
}
    }

    post {
        always {
            echo 'This will always run, regardless of success or failure.'
        }
        success {
            echo 'This runs only if the pipeline succeeds.'
        }
        failure {
            echo 'This runs only if the pipeline fails.'
        }
        unstable {
            echo 'This runs if the pipeline is unstable (e.g., some tests failed).'
        }
        changed {
            echo 'This runs if the current build result is different from the previous build.'
        }
    }
}


Explanation of post Actions

always
Runs at the end of the pipeline, no matter the outcome (success, failure, unstable, aborted).
Example: Logging, cleanup tasks, sending notifications.

success
Executes only if the pipeline finishes successfully.
Example: Deploying an application, sending a success notification.

failure
Executes only if any stage of the pipeline fails.
Example: Sending alerts to the development team, collecting logs.


unstable
Runs if the build is marked unstable (e.g., unit tests failed but the build didn’t crash).
Example: Marking the build with warnings, notifying QA teams.


changed
Runs only if the build status has changed compared to the last build (e.g., from success to failure or vice versa).
Example: Sending a notification when the pipeline goes from failing to passing or vice versa.

When to Use post Actions?

always: Cleanup tasks, logging, archiving artifacts.
success: Deployment, tagging successful builds.
failure: Sending failure notifications, debugging logs.
unstable: Reporting flaky tests or performance regressions.
changed: Notifying when the pipeline result differs from the last execution.