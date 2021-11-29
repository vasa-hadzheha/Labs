import React from 'react';
import { Layout } from 'antd';
import Sidebar from './Sidebar';


const { Header, Content, Footer} = Layout;

const MainLayout = ({children}) => {

    return (
        <Layout style={{ minHeight: '100vh'}}>
            <Sidebar />
        <Layout className="site-layout">
          <Header className="site-layout-background" style={{ padding: 0 }} />
          <Content style={{ margin: '0 16px' }}>
            <div className="site-layout-background" style={{ padding: 24, minHeight: 360 }}>
              {children}
            </div>
          </Content>
          <Footer style={{ textAlign: 'center' }}>Слава Україні</Footer>
        </Layout>
        </Layout>
    )
}

export default MainLayout