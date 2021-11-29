import 'antd/dist/antd.css';
import useRoutes from './components/routes/routes';

function App() {

  const routes = useRoutes();
  return (
    <>
      {routes}
    </>
  );
}

export default App;
