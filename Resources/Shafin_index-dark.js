import Head from "next/head";
import { useEffect } from "react";
import BIO from "../src/components/BIO";
import RESEARCH from "../src/components/RESEARCH & SCHOLARSHIP";
import PUBLICATIONS from "../src/components/PUBLICATIONS";
import TEACHING from "../src/components/TEACHING";
import Contact from "../src/components/Contact";
import Home from "../src/components/Home";
import Layout from "../src/layout/Layout";

const Portfolio = dynamic(() => import("../src/components/Portfolio"), {
  ssr: false,
});

const Index = () => {
  useEffect(() => {
    document.querySelector("body").classList.add("dark");
  }, []);

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