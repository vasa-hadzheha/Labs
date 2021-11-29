import React from 'react'
import loadable from '@loadable/component'
import {
    Routes,
    Route,
    BrowserRouter as Router,
} from 'react-router-dom'
import MainLayout from '../layout/MainLayout'

const Dashboard = loadable(() => import('../../pages/dashboard/Dashboard'))
// const Profile = loadable(() => import('../../pages/Profile/Profile')) 
// const Grades = loadable(() => import('../../pages/Grades')) 
// const Homeworks = loadable(() => import('../../pages/Homeworks/Homeworks')) 
// const Statistic = loadable(() => import('../../pages/Statistic')) 
// const Registration = loadable(() => import('../../pages/Auth/Registration')) 
// const Login = loadable(() => import('../../pages/Auth/Login')) 

const useRoutes = () => {
    return (
        <MainLayout>
            <Routes>
                <Route path="/dashboard" element={<Dashboard />} />
                {/* <Route path="/profile" component={Profile} />
                    <Route path="/grades" component={Grades} />
                    <Route path="/homeworks" component={Homeworks} />
                    <Route path="/statistic" component={Statistic} />
                    <Route path="/registration" component={Registration} />
                    <Route path="/login" component={Login} /> */}
            </Routes>
        </MainLayout>
    );
};

export default useRoutes