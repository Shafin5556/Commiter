import Head from "next/head";
import BIO from "../src/components/BIO";
import RESEARCH from "../src/components/RESEARCH";
import PUBLICATIONS from "../src/components/PUBLICATIONS";
import TEACHING from "../src/components/TEACHING";
import Contact from "../src/components/Contact";
import Home from "../src/components/Home";
import Layout from "../src/layout/Layout";

const Index = () => {
  return (
    <Layout>
      <Head>
        <title>Stanford | PROFILES</title>
      </Head>
      <Home />
      {/* HERO */}
      {/* PROCESS */}
      <BIO />
      {/* /BIO */}
      {/* BIO */}
      <RESEARCH />
      {/* /RESEARCH */}
      {/* RESEARCH */}
      <PUBLICATIONS />
      {/* /PUBLICATIONS  */}
      {/* PUBLICATIONS  */}
      <TEACHING />
      {/* /TEACHING  */}
      {/* TEACHING  */}
      <Contact />
    </Layout>
  );
};
export default Index;