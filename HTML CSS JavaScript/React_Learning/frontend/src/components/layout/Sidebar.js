import React from 'react';
import { Layout, Menu } from 'antd';
import {
    DesktopOutlined,
    PieChartOutlined,
    UserOutlined,
} from '@ant-design/icons'
import { Link } from 'react-router-dom'

const { SubMenu} = Menu;
const { Sider } = Layout;

const Sidebar = () => {

    return (
        <Sider>
                <Menu theme="dark" defaultSelectedKeys={['dashboard']} mode='vertical'>
                    <Menu.Item key='dashboard' icon={< DesktopOutlined />}>
                        <Link to="/dashboard"> Dashboard </Link>
                    </Menu.Item>
                    <SubMenu key="sub1" icon={< UserOutlined />} title="User">
                        <Menu.Item key='profile'>
                            <Link to="/profile"> Сторінка 1 </Link>
                        </Menu.Item>
                        <Menu.Item key='grades'>
                            <Link to="/grades"> Сторінка 2 </Link>
                        </Menu.Item>
                        <Menu.Item key='homeworks'>
                            <Link to="/homeworks"> Сторінка 3 </Link>
                        </Menu.Item>
                    </SubMenu>
                    <Menu.Item key='statistic' icon={< PieChartOutlined />}>
                        <Link to="/statistic"> Сторінка 4 </Link>
                    </Menu.Item>
                </Menu>
        </Sider>
    )
}

export default Sidebar